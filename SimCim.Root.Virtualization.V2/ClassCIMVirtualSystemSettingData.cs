using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMVirtualSystemSettingData : CIMSettingData
    {
        protected CIMVirtualSystemSettingData()
        {
        }

        protected CIMVirtualSystemSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AutomaticRecoveryAction
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AutomaticRecoveryAction", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutomaticRecoveryAction", value);
            }
        }

        public System.UInt16? AutomaticShutdownAction
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AutomaticShutdownAction", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutomaticShutdownAction", value);
            }
        }

        public System.UInt16? AutomaticStartupAction
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AutomaticStartupAction", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutomaticStartupAction", value);
            }
        }

        public System.DateTime? AutomaticStartupActionDelay
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("AutomaticStartupActionDelay", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutomaticStartupActionDelay", value);
            }
        }

        public System.UInt16? AutomaticStartupActionSequenceNumber
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AutomaticStartupActionSequenceNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutomaticStartupActionSequenceNumber", value);
            }
        }

        public System.String ConfigurationDataRoot
        {
            get
            {
                System.String result;
                this.GetProperty("ConfigurationDataRoot", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConfigurationDataRoot", value);
            }
        }

        public System.String ConfigurationFile
        {
            get
            {
                System.String result;
                this.GetProperty("ConfigurationFile", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConfigurationFile", value);
            }
        }

        public System.String ConfigurationID
        {
            get
            {
                System.String result;
                this.GetProperty("ConfigurationID", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConfigurationID", value);
            }
        }

        public System.DateTime? CreationTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("CreationTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("CreationTime", value);
            }
        }

        public System.String LogDataRoot
        {
            get
            {
                System.String result;
                this.GetProperty("LogDataRoot", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogDataRoot", value);
            }
        }

        public System.String[] Notes
        {
            get
            {
                System.String[] result;
                this.GetProperty("Notes", out result);
                return result;
            }

            set
            {
                this.SetProperty("Notes", value);
            }
        }

        public System.String RecoveryFile
        {
            get
            {
                System.String result;
                this.GetProperty("RecoveryFile", out result);
                return result;
            }

            set
            {
                this.SetProperty("RecoveryFile", value);
            }
        }

        public System.String SnapshotDataRoot
        {
            get
            {
                System.String result;
                this.GetProperty("SnapshotDataRoot", out result);
                return result;
            }

            set
            {
                this.SetProperty("SnapshotDataRoot", value);
            }
        }

        public System.String SuspendDataRoot
        {
            get
            {
                System.String result;
                this.GetProperty("SuspendDataRoot", out result);
                return result;
            }

            set
            {
                this.SetProperty("SuspendDataRoot", value);
            }
        }

        public System.String SwapFileDataRoot
        {
            get
            {
                System.String result;
                this.GetProperty("SwapFileDataRoot", out result);
                return result;
            }

            set
            {
                this.SetProperty("SwapFileDataRoot", value);
            }
        }

        public System.String VirtualSystemIdentifier
        {
            get
            {
                System.String result;
                this.GetProperty("VirtualSystemIdentifier", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualSystemIdentifier", value);
            }
        }

        public System.String VirtualSystemType
        {
            get
            {
                System.String result;
                this.GetProperty("VirtualSystemType", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualSystemType", value);
            }
        }
    }
}