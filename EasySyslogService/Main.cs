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
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.Net;
using Fantail.Libraries.Syslog;
using EasySyslogMonitor;

namespace EasySyslogService {
   public partial class Main : ServiceBase {
      SyslogListener syslogListener;
      MemoryBuffer memoryBuffer;

      easysyslogmonDataSet1 dsMain;
      EasySyslogMonitor.easysyslogmonDataSet1TableAdapters.rulesTableAdapter taRules;
      SyslogParser parser;

      public Main() {
         InitializeComponent();
         
         syslogListener = new SyslogListener(IPAddress.Any);
         dsMain = new easysyslogmonDataSet1();
         taRules = new EasySyslogMonitor.easysyslogmonDataSet1TableAdapters.rulesTableAdapter();
         taRules.Fill(dsMain.rules);
         parser = new SyslogParser(dsMain.rules);
         memoryBuffer = new MemoryBuffer(TimeSpan.FromSeconds(30), parser);
         syslogListener.MessageReceived += new MessageReceivedEventHandler(syslogListener_MessageReceived);
      }


      void syslogListener_MessageReceived(MessageReceivedEventArgs e) {
         memoryBuffer.PushMessage(e.SyslogMessage);
      }
      protected override void OnStart(string[] args) {
         syslogListener.Start();
         EventLogger.WriteEventToWindowsLog("Service Starting...", EventLogEntryType.Information);
      }

      protected override void OnStop() {
         syslogListener.Stop();
         EventLogger.WriteEventToWindowsLog("Service Stopping...", EventLogEntryType.Information);
         memoryBuffer.Flush();
      }
   }
}
