using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMServiceServiceDependency : CIMDependency
    {
        protected CIMServiceServiceDependency()
        {
        }

        protected CIMServiceServiceDependency(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMService Antecedent
        {
            get
            {
                CIMService result;
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

        public System.UInt16? TypeOfDependency
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TypeOfDependency", out result);
                return result;
            }
        }
    }
}