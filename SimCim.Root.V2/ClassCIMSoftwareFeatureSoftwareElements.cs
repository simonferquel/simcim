using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSoftwareFeatureSoftwareElements : CIMComponent
    {
        protected CIMSoftwareFeatureSoftwareElements()
        {
        }

        protected CIMSoftwareFeatureSoftwareElements(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMSoftwareFeature GroupComponent
        {
            get
            {
                CIMSoftwareFeature result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new CIMSoftwareElement PartComponent
        {
            get
            {
                CIMSoftwareElement result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}