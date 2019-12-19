using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public abstract class MSFTNetEventPacketCaptureTarget : CIMLogicalElement
    {
        protected MSFTNetEventPacketCaptureTarget()
        {
        }

        protected MSFTNetEventPacketCaptureTarget(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CaptureStatus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CaptureStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("CaptureStatus", value);
            }
        }

        public System.String Id
        {
            get
            {
                System.String result;
                this.GetProperty("Id", out result);
                return result;
            }

            set
            {
                this.SetProperty("Id", value);
            }
        }

        public System.String ProviderName
        {
            get
            {
                System.String result;
                this.GetProperty("ProviderName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderName", value);
            }
        }
    }
}