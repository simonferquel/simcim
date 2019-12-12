using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMPortOnDevice : CIMHostedDependency
    {
        protected CIMPortOnDevice()
        {
        }

        protected CIMPortOnDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMLogicalDevice Antecedent
        {
            get
            {
                CIMLogicalDevice result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new CIMLogicalPort Dependent
        {
            get
            {
                CIMLogicalPort result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Dependent", value);
            }
        }
    }
}