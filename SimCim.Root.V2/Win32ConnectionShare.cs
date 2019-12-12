using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ConnectionShare : CIMDependency
    {
        public Win32ConnectionShare()
        {
        }

        public Win32ConnectionShare(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32Share Antecedent
        {
            get
            {
                Win32Share result;
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