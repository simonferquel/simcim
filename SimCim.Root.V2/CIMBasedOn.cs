using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMBasedOn : CIMDependency
    {
        protected CIMBasedOn()
        {
        }

        protected CIMBasedOn(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMStorageExtent Antecedent
        {
            get
            {
                CIMStorageExtent result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMStorageExtent Dependent
        {
            get
            {
                CIMStorageExtent result;
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