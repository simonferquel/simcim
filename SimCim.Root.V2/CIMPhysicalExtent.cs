using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPhysicalExtent : CIMStorageExtent
    {
        protected CIMPhysicalExtent()
        {
        }

        protected CIMPhysicalExtent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? UnitsBeforeCheckDataInterleave
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("UnitsBeforeCheckDataInterleave", out result);
                return result;
            }
        }

        public System.UInt64? UnitsOfCheckData
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("UnitsOfCheckData", out result);
                return result;
            }
        }

        public System.UInt64? UnitsOfUserData
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("UnitsOfUserData", out result);
                return result;
            }
        }
    }
}