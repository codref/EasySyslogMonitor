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
using System.Timers;
using System.Threading;

namespace EasySyslogMonitor {
   public class MemoryBuffer {
      private List<SyslogMessage> buffer = new List<SyslogMessage>();
      private TimeSpan commitInterval;
      private System.Timers.Timer timer = new System.Timers.Timer();      
      private Mutex bufferLock = new Mutex(false);
      private SyslogParser parser;

      public MemoryBuffer(TimeSpan commitInterval, SyslogParser sp) {
         this.commitInterval = commitInterval;
         this.timer.Interval = commitInterval.TotalMilliseconds;
         parser = sp;
         this.timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
         this.timer.Enabled = true;
      }

      void timer_Elapsed(object sender, ElapsedEventArgs e) {
         Flush();
      }

      /// <summary>
      /// Posts a new message to the buffer, for committing to the database when the internal timer elapses.
      /// </summary>
      /// <param name="sm">The syslog message to be submitted.</param>
      public void PushMessage(SyslogMessage sm) {
         bufferLock.WaitOne();
         buffer.Add(sm);
         bufferLock.ReleaseMutex();
      }

      /// <summary>
      /// Flushes the buffer.  This method can be called by the user to ensure that final in-memory entries are
      /// written to the database.
      /// </summary>
      public void Flush() {
         bufferLock.WaitOne();
         try {
            parser.MatchRule(buffer);
            buffer.Clear();
         } finally {
            bufferLock.ReleaseMutex();
         }
      }
   }
}
