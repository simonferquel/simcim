using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMLogicalDiskBasedOnPartition : CIMBasedOn
    {
        protected CIMLogicalDiskBasedOnPartition()
        {
        }

        protected CIMLogicalDiskBasedOnPartition(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMDiskPartition Antecedent
        {
            get
            {
                CIMDiskPartition result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMLogicalDisk Dependent
        {
            get
            {
                CIMLogicalDisk result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}