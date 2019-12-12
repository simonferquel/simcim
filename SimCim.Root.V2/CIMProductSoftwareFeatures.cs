using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMProductSoftwareFeatures : GenericInfrastructureObject
    {
        protected CIMProductSoftwareFeatures()
        {
        }

        protected CIMProductSoftwareFeatures(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMSoftwareFeature Component
        {
            get
            {
                CIMSoftwareFeature result;
                this.GetInfrastructureObjectProperty("Component", out result);
                return result;
            }
        }

        public CIMProduct Product
        {
            get
            {
                CIMProduct result;
                this.GetInfrastructureObjectProperty("Product", out result);
                return result;
            }
        }
    }
}