using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterGroupAffinity : GenericInfrastructureObject
    {
        public MSFTNetAdapterGroupAffinity()
        {
        }

        public MSFTNetAdapterGroupAffinity(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? ProcessorAffinityMask
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProcessorAffinityMask", out result);
                return result;
            }
        }

        public System.UInt16? ProcessorGroup
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ProcessorGroup", out result);
                return result;
            }
        }
    }
}