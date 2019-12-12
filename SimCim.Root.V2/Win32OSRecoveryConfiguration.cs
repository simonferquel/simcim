using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OSRecoveryConfiguration : CIMSetting
    {
        public Win32OSRecoveryConfiguration()
        {
        }

        public Win32OSRecoveryConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AutoReboot
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AutoReboot", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutoReboot", value);
            }
        }

        public System.String DebugFilePath
        {
            get
            {
                System.String result;
                this.GetProperty("DebugFilePath", out result);
                return result;
            }

            set
            {
                this.SetProperty("DebugFilePath", value);
            }
        }

        public System.UInt32? DebugInfoType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DebugInfoType", out result);
                return result;
            }

            set
            {
                this.SetProperty("DebugInfoType", value);
            }
        }

        public System.String ExpandedDebugFilePath
        {
            get
            {
                System.String result;
                this.GetProperty("ExpandedDebugFilePath", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExpandedDebugFilePath", value);
            }
        }

        public System.String ExpandedMiniDumpDirectory
        {
            get
            {
                System.String result;
                this.GetProperty("ExpandedMiniDumpDirectory", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExpandedMiniDumpDirectory", value);
            }
        }

        public System.Boolean? KernelDumpOnly
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("KernelDumpOnly", out result);
                return result;
            }

            set
            {
                this.SetProperty("KernelDumpOnly", value);
            }
        }

        public System.String MiniDumpDirectory
        {
            get
            {
                System.String result;
                this.GetProperty("MiniDumpDirectory", out result);
                return result;
            }

            set
            {
                this.SetProperty("MiniDumpDirectory", value);
            }
        }

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
                return result;
            }
        }

        public System.Boolean? OverwriteExistingDebugFile
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("OverwriteExistingDebugFile", out result);
                return result;
            }

            set
            {
                this.SetProperty("OverwriteExistingDebugFile", value);
            }
        }

        public System.Boolean? SendAdminAlert
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SendAdminAlert", out result);
                return result;
            }

            set
            {
                this.SetProperty("SendAdminAlert", value);
            }
        }

        public System.Boolean? WriteDebugInfo
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("WriteDebugInfo", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteDebugInfo", value);
            }
        }

        public System.Boolean? WriteToSystemLog
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("WriteToSystemLog", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteToSystemLog", value);
            }
        }
    }
}