using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterVmqFilter : GenericInfrastructureObject
    {
        public MSFTNetAdapterVmqFilter()
        {
        }

        public MSFTNetAdapterVmqFilter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? FilterID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FilterID", out result);
                return result;
            }
        }

        public System.String MacAddress
        {
            get
            {
                System.String result;
                this.GetProperty("MacAddress", out result);
                return result;
            }
        }

        public System.UInt16? VlanID
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("VlanID", out result);
                return result;
            }
        }
    }
}