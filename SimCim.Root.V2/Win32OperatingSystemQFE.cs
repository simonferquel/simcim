using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OperatingSystemQFE : CIMDependency
    {
        public Win32OperatingSystemQFE()
        {
        }

        public Win32OperatingSystemQFE(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32OperatingSystem Antecedent
        {
            get
            {
                Win32OperatingSystem result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32QuickFixEngineering Dependent
        {
            get
            {
                Win32QuickFixEngineering result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}