using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32AllocatedResource : CIMDependency
    {
        public Win32AllocatedResource()
        {
        }

        public Win32AllocatedResource(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMSystemResource Antecedent
        {
            get
            {
                CIMSystemResource result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMLogicalDevice Dependent
        {
            get
            {
                CIMLogicalDevice result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}