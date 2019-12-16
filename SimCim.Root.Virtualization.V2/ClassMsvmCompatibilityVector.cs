using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmCompatibilityVector : GenericInfrastructureObject
    {
        public MsvmCompatibilityVector()
        {
        }

        public MsvmCompatibilityVector(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CompareOperation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CompareOperation", out result);
                return result;
            }
        }

        public System.UInt64? CompatibilityInfo
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CompatibilityInfo", out result);
                return result;
            }
        }

        public System.UInt32? VectorId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VectorId", out result);
                return result;
            }
        }
    }
}