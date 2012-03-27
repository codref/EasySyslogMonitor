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
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Fantail.Libraries.Syslog;

namespace EasySyslogMonitor {
   public partial class FrmMain : Form {
      SyslogListener syslogListener;
      public delegate void UpdateTextCallback(SyslogMessage sm);
      MemoryBuffer memoryBuffer;
      easysyslogmonDataSet1 dsMain;
      easysyslogmonDataSet1TableAdapters.rulesTableAdapter taRules;
      SyslogParser parser;

      public FrmMain() {
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
         if (btnShowMessages.Checked)
            grdMessages.BeginInvoke(new UpdateTextCallback(UpdateText), new Object[] {e.SyslogMessage});
      }

      private void btnStart_Click(object sender, EventArgs e) {
         
      }
      
      private void UpdateText(SyslogMessage sm)
        {
         grdMessages.Rows.Add(new Object[] {sm.Timestamp.ToString(),sm.Hostname, sm.Severity.Value.ToString(), sm.Facility.Value.ToString(), sm.Message});
        }

      private void btnStart1_Click(object sender, EventArgs e) {
         syslogListener.Start();
         btnStart1.Enabled = false;
         btnStop.Enabled = true;
      }

      private void btnStop_Click(object sender, EventArgs e) {
         syslogListener.Stop();
         memoryBuffer.Flush();
         btnStart1.Enabled = true;
         btnStop.Enabled = false;
      }

      private void btnShowMessages_Click(object sender, EventArgs e) {

      }

      private void rulesBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
         this.Validate();
         this.rulesBindingSource.EndEdit();
         this.tableAdapterManager.UpdateAll(this.easysyslogmonDataSet);

      }

      private void FrmMain_Load(object sender, EventArgs e) {
         // TODO: This line of code loads data into the 'easysyslogmonDataSet.rules' table. You can move, or remove it, as needed.
         this.rulesTableAdapter.Fill(this.easysyslogmonDataSet.rules);

      }

      private void FrmMain_FormClosed(object sender, FormClosedEventArgs e) {
         if (!btnStart1.Enabled)
            btnStop_Click(sender, null);
      }
   }
}
