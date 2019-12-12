using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSoftwareFeatureServiceImplementation : CIMDependency
    {
        protected CIMSoftwareFeatureServiceImplementation()
        {
        }

        protected CIMSoftwareFeatureServiceImplementation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMSoftwareFeature Antecedent
        {
            get
            {
                CIMSoftwareFeature result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMService Dependent
        {
            get
            {
                CIMService result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}