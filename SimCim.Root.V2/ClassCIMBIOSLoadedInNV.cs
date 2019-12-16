using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMBIOSLoadedInNV : CIMDependency
    {
        protected CIMBIOSLoadedInNV()
        {
        }

        protected CIMBIOSLoadedInNV(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMNonVolatileStorage Antecedent
        {
            get
            {
                CIMNonVolatileStorage result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMBIOSElement Dependent
        {
            get
            {
                CIMBIOSElement result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }

        public System.UInt64? EndingAddress
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EndingAddress", out result);
                return result;
            }
        }

        public System.UInt64? StartingAddress
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("StartingAddress", out result);
                return result;
            }
        }
    }
}