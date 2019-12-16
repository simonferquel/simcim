using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LogicalProgramGroupDirectory : CIMDependency
    {
        public Win32LogicalProgramGroupDirectory()
        {
        }

        public Win32LogicalProgramGroupDirectory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32LogicalProgramGroup Antecedent
        {
            get
            {
                Win32LogicalProgramGroup result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32Directory Dependent
        {
            get
            {
                Win32Directory result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}