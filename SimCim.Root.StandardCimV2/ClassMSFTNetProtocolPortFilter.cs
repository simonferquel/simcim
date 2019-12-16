using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetProtocolPortFilter : CIMFilterEntryBase
    {
        public MSFTNetProtocolPortFilter()
        {
        }

        public MSFTNetProtocolPortFilter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? DynamicTransport
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DynamicTransport", out result);
                return result;
            }

            set
            {
                this.SetProperty("DynamicTransport", value);
            }
        }

        public System.String[] IcmpType
        {
            get
            {
                System.String[] result;
                this.GetProperty("IcmpType", out result);
                return result;
            }

            set
            {
                this.SetProperty("IcmpType", value);
            }
        }

        public System.String[] LocalPort
        {
            get
            {
                System.String[] result;
                this.GetProperty("LocalPort", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalPort", value);
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

        public System.String[] RemotePort
        {
            get
            {
                System.String[] result;
                this.GetProperty("RemotePort", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemotePort", value);
            }
        }
    }
}