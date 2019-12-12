using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMLogicalDiskBasedOnVolumeSet : CIMBasedOn
    {
        protected CIMLogicalDiskBasedOnVolumeSet()
        {
        }

        protected CIMLogicalDiskBasedOnVolumeSet(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMVolumeSet Antecedent
        {
            get
            {
                CIMVolumeSet result;
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