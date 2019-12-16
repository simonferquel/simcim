using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMForwardingService : CIMNetworkService
    {
        protected CIMForwardingService()
        {
        }

        protected CIMForwardingService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String OtherProtocolType
        {
            get
            {
                System.String result;
                this.GetProperty("OtherProtocolType", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherProtocolType", value);
            }
        }

        public System.UInt16? ProtocolType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ProtocolType", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProtocolType", value);
            }
        }
    }
}