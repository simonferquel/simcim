using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMEnabledLogicalElementCapabilities : CIMCapabilities
    {
        protected CIMEnabledLogicalElementCapabilities()
        {
        }

        protected CIMEnabledLogicalElementCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? ElementNameEditSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ElementNameEditSupported", out result);
                return result;
            }

            set
            {
                this.SetProperty("ElementNameEditSupported", value);
            }
        }

        public System.String ElementNameMask
        {
            get
            {
                System.String result;
                this.GetProperty("ElementNameMask", out result);
                return result;
            }

            set
            {
                this.SetProperty("ElementNameMask", value);
            }
        }

        public System.UInt16? MaxElementNameLen
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MaxElementNameLen", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxElementNameLen", value);
            }
        }

        public System.UInt16[] RequestedStatesSupported
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("RequestedStatesSupported", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestedStatesSupported", value);
            }
        }
    }
}