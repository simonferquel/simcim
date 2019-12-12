using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchPortExtendedAclSettingData : MsvmEthernetSwitchPortFeatureSettingData
    {
        public MsvmEthernetSwitchPortExtendedAclSettingData()
        {
        }

        public MsvmEthernetSwitchPortExtendedAclSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? Action
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Action", out result);
                return result;
            }

            set
            {
                this.SetProperty("Action", value);
            }
        }

        public System.Byte? Direction
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Direction", out result);
                return result;
            }

            set
            {
                this.SetProperty("Direction", value);
            }
        }

        public System.UInt16? IdleSessionTimeout
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("IdleSessionTimeout", out result);
                return result;
            }

            set
            {
                this.SetProperty("IdleSessionTimeout", value);
            }
        }

        public System.UInt32? IsolationID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IsolationID", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsolationID", value);
            }
        }

        public System.String LocalIPAddress
        {
            get
            {
                System.String result;
                this.GetProperty("LocalIPAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalIPAddress", value);
            }
        }

        public System.String LocalPort
        {
            get
            {
                System.String result;
                this.GetProperty("LocalPort", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalPort", value);
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

            set
            {
                this.SetProperty("Name", value);
            }
        }

        public System.String Protocol
        {
            get
            {
                System.String result;
                this.GetProperty("Protocol", out result);
                return result;
            }

            set
            {
                this.SetProperty("Protocol", value);
            }
        }

        public System.String RemoteIPAddress
        {
            get
            {
                System.String result;
                this.GetProperty("RemoteIPAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteIPAddress", value);
            }
        }

        public System.String RemotePort
        {
            get
            {
                System.String result;
                this.GetProperty("RemotePort", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemotePort", value);
            }
        }

        public System.Boolean? Stateful
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Stateful", out result);
                return result;
            }

            set
            {
                this.SetProperty("Stateful", value);
            }
        }

        public System.UInt16? Weight
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Weight", out result);
                return result;
            }

            set
            {
                this.SetProperty("Weight", value);
            }
        }
    }
}