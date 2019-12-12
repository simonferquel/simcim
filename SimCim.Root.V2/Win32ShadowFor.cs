using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ShadowFor : CIMDependency
    {
        public Win32ShadowFor()
        {
        }

        public Win32ShadowFor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32Volume Antecedent
        {
            get
            {
                Win32Volume result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32ShadowCopy Dependent
        {
            get
            {
                Win32ShadowCopy result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}