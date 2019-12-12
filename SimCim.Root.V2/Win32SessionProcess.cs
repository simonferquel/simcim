using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SessionProcess : Win32SessionResource
    {
        public Win32SessionProcess()
        {
        }

        public Win32SessionProcess(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public new Win32Process Dependent
        {
            get
            {
                Win32Process result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}