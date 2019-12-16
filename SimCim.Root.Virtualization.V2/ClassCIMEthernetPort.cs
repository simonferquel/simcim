using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMEthernetPort : CIMNetworkPort
    {
        protected CIMEthernetPort()
        {
        }

        protected CIMEthernetPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] Capabilities
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("Capabilities", out result);
                return result;
            }

            set
            {
                this.SetProperty("Capabilities", value);
            }
        }

        public System.String[] CapabilityDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("CapabilityDescriptions", out result);
                return result;
            }

            set
            {
                this.SetProperty("CapabilityDescriptions", value);
            }
        }

        public System.UInt16[] EnabledCapabilities
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("EnabledCapabilities", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnabledCapabilities", value);
            }
        }

        public System.UInt32? MaxDataSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxDataSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxDataSize", value);
            }
        }

        public System.String[] OtherEnabledCapabilities
        {
            get
            {
                System.String[] result;
                this.GetProperty("OtherEnabledCapabilities", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherEnabledCapabilities", value);
            }
        }
    }
}