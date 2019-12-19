using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class CIMNetworkPipe : CIMEnabledLogicalElement
    {
        public CIMNetworkPipe()
        {
        }

        public CIMNetworkPipe(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AggregationBehavior
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AggregationBehavior", out result);
                return result;
            }

            set
            {
                this.SetProperty("AggregationBehavior", value);
            }
        }

        public System.UInt16? Directionality
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Directionality", out result);
                return result;
            }

            set
            {
                this.SetProperty("Directionality", value);
            }
        }
    }
}