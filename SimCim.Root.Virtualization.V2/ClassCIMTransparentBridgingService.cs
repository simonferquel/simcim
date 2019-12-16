using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMTransparentBridgingService : CIMForwardingService
    {
        protected CIMTransparentBridgingService()
        {
        }

        protected CIMTransparentBridgingService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AgingTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AgingTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("AgingTime", value);
            }
        }

        public System.UInt32? FID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FID", out result);
                return result;
            }

            set
            {
                this.SetProperty("FID", value);
            }
        }
    }
}