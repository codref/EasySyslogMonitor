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
using System.Configuration.Install;
using System.ServiceProcess;
using System.Text;

namespace EasySyslogService {
   [RunInstaller(true)]
   public class WindowsServiceInstaller : Installer {
      /// <summary>

      /// Public Constructor for WindowsServiceInstaller.

      /// - Put all of your Initialization code here.

      /// </summary>

      public WindowsServiceInstaller() {
         ServiceProcessInstaller serviceProcessInstaller =
                            new ServiceProcessInstaller();
         ServiceInstaller serviceInstaller = new ServiceInstaller();

         //# Service Account Information

         serviceProcessInstaller.Account = ServiceAccount.LocalSystem;
         serviceProcessInstaller.Username = null;
         serviceProcessInstaller.Password = null;

         //# Service Information

         serviceInstaller.DisplayName = "Easy Syslog Monitor Windows Service";
         serviceInstaller.StartType = ServiceStartMode.Automatic;

         //# This must be identical to the WindowsService.ServiceBase name

         //# set in the constructor of WindowsService.cs

         serviceInstaller.ServiceName = "Easy Syslog Monitor Service";

         Installers.Add(serviceProcessInstaller);
         Installers.Add(serviceInstaller);
      }
   }
}
