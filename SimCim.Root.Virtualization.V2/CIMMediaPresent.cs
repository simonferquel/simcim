using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMMediaPresent : CIMDependency
    {
        protected CIMMediaPresent()
        {
        }

        protected CIMMediaPresent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMMediaAccessDevice Antecedent
        {
            get
            {
                CIMMediaAccessDevice result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
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

            set
            {
                this.SetProperty("Dependent", value);
            }
        }

        public System.Boolean? FixedMedia
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("FixedMedia", out result);
                return result;
            }

            set
            {
                this.SetProperty("FixedMedia", value);
            }
        }
    }
}