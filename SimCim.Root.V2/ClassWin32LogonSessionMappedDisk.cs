using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LogonSessionMappedDisk : CIMDependency
    {
        public Win32LogonSessionMappedDisk()
        {
        }

        public Win32LogonSessionMappedDisk(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32LogonSession Antecedent
        {
            get
            {
                Win32LogonSession result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32MappedLogicalDisk Dependent
        {
            get
            {
                Win32MappedLogicalDisk result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}