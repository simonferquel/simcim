using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SoftwareElementCondition : CIMCheck
    {
        public Win32SoftwareElementCondition()
        {
        }

        public Win32SoftwareElementCondition(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Condition
        {
            get
            {
                System.String result;
                this.GetProperty("Condition", out result);
                return result;
            }
        }
    }
}