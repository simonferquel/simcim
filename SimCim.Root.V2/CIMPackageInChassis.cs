using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPackageInChassis : CIMContainer
    {
        protected CIMPackageInChassis()
        {
        }

        protected CIMPackageInChassis(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMChassis GroupComponent
        {
            get
            {
                CIMChassis result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new CIMPhysicalPackage PartComponent
        {
            get
            {
                CIMPhysicalPackage result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}