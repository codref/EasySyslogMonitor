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
using System.Diagnostics;

namespace EasySyslogMonitor {
   public class EventLogger {
      public static void WriteEventToWindowsLog(string strEvent, EventLogEntryType type) {
         string strMyApp = "SyslogMonitor";
         if (!System.Diagnostics.EventLog.SourceExists(strMyApp))
            System.Diagnostics.EventLog.CreateEventSource(strMyApp, "Application");

         EventLog MyEventLog = new EventLog();
         MyEventLog.Source = strMyApp;
         MyEventLog.WriteEntry(strEvent, type);
      }

   }
}
