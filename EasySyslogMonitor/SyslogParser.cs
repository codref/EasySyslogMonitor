/*
    EasySyslogMonitor
    Copyright (C) 2009  Davide Dal Farra

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Text;
using Fantail.Libraries.Syslog;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Mail;
using System.Configuration;
using System.Net.Configuration;

namespace EasySyslogMonitor {
   public class SyslogParser {
      easysyslogmonDataSet1.rulesDataTable rules;
      Dictionary<string, string> templates;

      public SyslogParser(easysyslogmonDataSet1.rulesDataTable tRules) {
         rules = tRules;
         templates = new Dictionary<string, string>();
         foreach (easysyslogmonDataSet1.rulesRow rule in rules) {
            try {
               string tempTemplateString = System.IO.File.ReadAllText(rule.template);
               templates.Add(rule.template, tempTemplateString);
            } catch (Exception ex) {
               EventLogger.WriteEventToWindowsLog("Cannot find template " + rule.template + ".\n\n[" + ex.Message + "]", System.Diagnostics.EventLogEntryType.Error);
            }
         }
      }

      public void MatchRule(List<SyslogMessage> sms) {
         easysyslogmonDataSet1TableAdapters.configTableAdapter configTA = new EasySyslogMonitor.easysyslogmonDataSet1TableAdapters.configTableAdapter();
         string smtp_host = configTA.GetValue("smtp_host");
         string smtp_port = configTA.GetValue("smtp_port");
         string smtp_username = configTA.GetValue("smtp_username");
         string smtp_password = configTA.GetValue("smtp_password");
         string smtp_ssl = configTA.GetValue("smtp_ssl");
         string smtp_from = configTA.GetValue("smtp_from");



         //per ogni regola inserita
         foreach (easysyslogmonDataSet1.rulesRow rule in rules) {
            //per ogni messaggio syslog ricevuto
            Regex rxHostname = new Regex(rule.source_ip);
            Regex rxFacility = new Regex(rule.facility);
            Regex rxSeverity = new Regex(rule.severity);
            Regex rxPattern = new Regex(rule.pattern);

            List<SyslogMessage> triggered = new List<SyslogMessage>();
            foreach (SyslogMessage sm in sms) {
               if (rxHostname.IsMatch(sm.Hostname) &&
                   rxFacility.IsMatch(sm.Facility.ToString()) &&
                   rxSeverity.IsMatch(sm.Severity.ToString()) &&
                   rxPattern.IsMatch(sm.Message)) {
                  triggered.Add(sm);
               }
            }
            if (triggered.Count > 0) {
               // rule triggered!
               string template = templates[rule.template];
               template = template.Replace("{datetime}", DateTime.Now.ToString());
               template = template.Replace("{rule}", "[" + rule.id + "] " + rule.name);
               string rawdata = "";
               template = template.Replace("{count}", triggered.Count.ToString());
               foreach (SyslogMessage sm in triggered) {
                  rawdata += sm.Timestamp.ToString() + "\th:" + sm.Hostname + "\tf:" + sm.Facility.ToString() + "\ts:" +
                     sm.Severity + "\tm:" + sm.Message + "\n";
                  sms.Remove(sm);
               }
               template = template.Replace("{timestamps}", rawdata);
               template = template.Replace("{severity}", rule.severity.ToString());
               template = template.Replace("{facility}", rule.facility.ToString());
               template = template.Replace("{pattern}", rule.pattern);

               // send mail
               try {
                  MailMessage mail = new MailMessage();
                  //System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                  //MailSettingsSectionGroup mMailSettings = config.GetSectionGroup("system.net/mailSettings") as MailSettingsSectionGroup;

                  foreach (string address in rule.mailto.Split(';')) {
                     mail.To.Add(address);
                  }
                  //MailAddress mailAddress = new MailAddress(mMailSettings.Smtp.From);
                  MailAddress mailAddress = new MailAddress(smtp_from);
                  mail.From = mailAddress;
                  mail.Subject = rule.name + " is ON";
                  mail.Body = template;
                  SmtpClient smtpClient = new SmtpClient();
                  smtpClient.Host = smtp_host;
                  System.Net.NetworkCredential credentials = new System.Net.NetworkCredential();
                  credentials.UserName = smtp_username;
                  credentials.Password = smtp_password;
                  smtpClient.Credentials = credentials;
                  smtpClient.Port = Convert.ToInt32(smtp_port);
                  if (smtp_ssl == "1")
                     smtpClient.EnableSsl = true;
                  else
                     smtpClient.EnableSsl = false;
                  smtpClient.Send(mail);
                  EventLogger.WriteEventToWindowsLog("Sent:\n" + mail.Body, System.Diagnostics.EventLogEntryType.Information);
               } catch (Exception ex) {
                  EventLogger.WriteEventToWindowsLog("Sendmail error. \n\n[" + ex.Message + "]", System.Diagnostics.EventLogEntryType.Error);
               }
            }
         }
      }
   }
}
