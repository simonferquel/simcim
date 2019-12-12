using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SessionConnection : CIMDependency
    {
        public Win32SessionConnection()
        {
        }

        public Win32SessionConnection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32ServerSession Antecedent
        {
            get
            {
                Win32ServerSession result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32ServerConnection Dependent
        {
            get
            {
                Win32ServerConnection result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}