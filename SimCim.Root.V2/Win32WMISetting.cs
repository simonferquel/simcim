using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32WMISetting : CIMSetting
    {
        public Win32WMISetting()
        {
        }

        public Win32WMISetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ASPScriptDefaultNamespace
        {
            get
            {
                System.String result;
                this.GetProperty("ASPScriptDefaultNamespace", out result);
                return result;
            }

            set
            {
                this.SetProperty("ASPScriptDefaultNamespace", value);
            }
        }

        public System.Boolean? ASPScriptEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ASPScriptEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("ASPScriptEnabled", value);
            }
        }

        public System.String[] AutorecoverMofs
        {
            get
            {
                System.String[] result;
                this.GetProperty("AutorecoverMofs", out result);
                return result;
            }
        }

        public System.UInt32? AutoStartWin9X
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AutoStartWin9X", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutoStartWin9X", value);
            }
        }

        public System.UInt32? BackupInterval
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BackupInterval", out result);
                return result;
            }

            set
            {
                this.SetProperty("BackupInterval", value);
            }
        }

        public System.DateTime? BackupLastTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("BackupLastTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("BackupLastTime", value);
            }
        }

        public System.String BuildVersion
        {
            get
            {
                System.String result;
                this.GetProperty("BuildVersion", out result);
                return result;
            }
        }

        public System.String DatabaseDirectory
        {
            get
            {
                System.String result;
                this.GetProperty("DatabaseDirectory", out result);
                return result;
            }
        }

        public System.UInt32? DatabaseMaxSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatabaseMaxSize", out result);
                return result;
            }
        }

        public System.Boolean? EnableAnonWin9xConnections
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableAnonWin9xConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnableAnonWin9xConnections", value);
            }
        }

        public System.Boolean? EnableEvents
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableEvents", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnableEvents", value);
            }
        }

        public System.Boolean? EnableStartupHeapPreallocation
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableStartupHeapPreallocation", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnableStartupHeapPreallocation", value);
            }
        }

        public System.UInt32? HighThresholdOnClientObjects
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HighThresholdOnClientObjects", out result);
                return result;
            }

            set
            {
                this.SetProperty("HighThresholdOnClientObjects", value);
            }
        }

        public System.UInt32? HighThresholdOnEvents
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HighThresholdOnEvents", out result);
                return result;
            }

            set
            {
                this.SetProperty("HighThresholdOnEvents", value);
            }
        }

        public System.String InstallationDirectory
        {
            get
            {
                System.String result;
                this.GetProperty("InstallationDirectory", out result);
                return result;
            }
        }

        public System.UInt32? LastStartupHeapPreallocation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LastStartupHeapPreallocation", out result);
                return result;
            }
        }

        public System.String LoggingDirectory
        {
            get
            {
                System.String result;
                this.GetProperty("LoggingDirectory", out result);
                return result;
            }

            set
            {
                this.SetProperty("LoggingDirectory", value);
            }
        }

        public System.UInt32? LoggingLevel
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LoggingLevel", out result);
                return result;
            }

            set
            {
                this.SetProperty("LoggingLevel", value);
            }
        }

        public System.UInt32? LowThresholdOnClientObjects
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LowThresholdOnClientObjects", out result);
                return result;
            }

            set
            {
                this.SetProperty("LowThresholdOnClientObjects", value);
            }
        }

        public System.UInt32? LowThresholdOnEvents
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LowThresholdOnEvents", out result);
                return result;
            }

            set
            {
                this.SetProperty("LowThresholdOnEvents", value);
            }
        }

        public System.UInt32? MaxLogFileSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxLogFileSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxLogFileSize", value);
            }
        }

        public System.UInt32? MaxWaitOnClientObjects
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxWaitOnClientObjects", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxWaitOnClientObjects", value);
            }
        }

        public System.UInt32? MaxWaitOnEvents
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxWaitOnEvents", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxWaitOnEvents", value);
            }
        }

        public System.String MofSelfInstallDirectory
        {
            get
            {
                System.String result;
                this.GetProperty("MofSelfInstallDirectory", out result);
                return result;
            }
        }

        public Win32Service ResolveWin32WMIElementSettingElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_WMIElementSetting", "Win32_Service", "Setting", "Element");
            return instances.Select(i => (Win32Service)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}