using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetNatTransitionMonitoring : MSFTNetSettingData
    {
        public MSFTNetNatTransitionMonitoring()
        {
        }

        public MSFTNetNatTransitionMonitoring(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String InboundAddress
        {
            get
            {
                System.String result;
                this.GetProperty("InboundAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("InboundAddress", value);
            }
        }

        public System.String NatOutboundAddress
        {
            get
            {
                System.String result;
                this.GetProperty("NatOutboundAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("NatOutboundAddress", value);
            }
        }

        public System.String OutboundAddress
        {
            get
            {
                System.String result;
                this.GetProperty("OutboundAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutboundAddress", value);
            }
        }

        public System.UInt32? TransportProtocol
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransportProtocol", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransportProtocol", value);
            }
        }
    }
}