using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LaunchCondition : CIMCheck
    {
        public Win32LaunchCondition()
        {
        }

        public Win32LaunchCondition(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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