using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DfsNodeTarget : CIMDependency
    {
        public Win32DfsNodeTarget()
        {
        }

        public Win32DfsNodeTarget(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32DfsTarget Antecedent
        {
            get
            {
                Win32DfsTarget result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32DfsNode Dependent
        {
            get
            {
                Win32DfsNode result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}