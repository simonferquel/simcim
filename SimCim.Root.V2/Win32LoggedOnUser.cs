using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LoggedOnUser : CIMDependency
    {
        public Win32LoggedOnUser()
        {
        }

        public Win32LoggedOnUser(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32Account Antecedent
        {
            get
            {
                Win32Account result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32LogonSession Dependent
        {
            get
            {
                Win32LogonSession result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}