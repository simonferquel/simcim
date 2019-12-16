using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SoftwareFeatureParent : CIMDependency
    {
        public Win32SoftwareFeatureParent()
        {
        }

        public Win32SoftwareFeatureParent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32SoftwareFeature Antecedent
        {
            get
            {
                Win32SoftwareFeature result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32SoftwareFeature Dependent
        {
            get
            {
                Win32SoftwareFeature result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}