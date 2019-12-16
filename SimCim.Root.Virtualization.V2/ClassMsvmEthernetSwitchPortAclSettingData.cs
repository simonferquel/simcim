using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchPortAclSettingData : MsvmEthernetSwitchPortFeatureSettingData
    {
        public MsvmEthernetSwitchPortAclSettingData()
        {
        }

        public MsvmEthernetSwitchPortAclSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? AclType
        {
            get
            {
                System.Byte? result;
                this.GetProperty("AclType", out result);
                return result;
            }

            set
            {
                this.SetProperty("AclType", value);
            }
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

        public System.Byte? Applicability
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Applicability", out result);
                return result;
            }

            set
            {
                this.SetProperty("Applicability", value);
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

        public System.String LocalAddress
        {
            get
            {
                System.String result;
                this.GetProperty("LocalAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalAddress", value);
            }
        }

        public System.Byte? LocalAddressPrefixLength
        {
            get
            {
                System.Byte? result;
                this.GetProperty("LocalAddressPrefixLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalAddressPrefixLength", value);
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

        public System.String RemoteAddress
        {
            get
            {
                System.String result;
                this.GetProperty("RemoteAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteAddress", value);
            }
        }

        public System.Byte? RemoteAddressPrefixLength
        {
            get
            {
                System.Byte? result;
                this.GetProperty("RemoteAddressPrefixLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteAddressPrefixLength", value);
            }
        }
    }
}