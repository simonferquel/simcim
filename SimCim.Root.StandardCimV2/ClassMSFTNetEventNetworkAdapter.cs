using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetEventNetworkAdapter : MSFTNetEventPacketCaptureTarget
    {
        public MSFTNetEventNetworkAdapter()
        {
        }

        public MSFTNetEventNetworkAdapter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String InterfaceDescription
        {
            get
            {
                System.String result;
                this.GetProperty("InterfaceDescription", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterfaceDescription", value);
            }
        }

        public System.Boolean? PromiscuousMode
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PromiscuousMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("PromiscuousMode", value);
            }
        }
    }
}