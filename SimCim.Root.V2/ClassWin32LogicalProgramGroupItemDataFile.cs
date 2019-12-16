using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LogicalProgramGroupItemDataFile : CIMDependency
    {
        public Win32LogicalProgramGroupItemDataFile()
        {
        }

        public Win32LogicalProgramGroupItemDataFile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32LogicalProgramGroupItem Antecedent
        {
            get
            {
                Win32LogicalProgramGroupItem result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMDataFile Dependent
        {
            get
            {
                CIMDataFile result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}