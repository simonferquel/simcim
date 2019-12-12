using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32EnvironmentSpecification : CIMCheck
    {
        public Win32EnvironmentSpecification()
        {
        }

        public Win32EnvironmentSpecification(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Environment
        {
            get
            {
                System.String result;
                this.GetProperty("Environment", out result);
                return result;
            }
        }

        public System.String Value
        {
            get
            {
                System.String result;
                this.GetProperty("Value", out result);
                return result;
            }
        }
    }
}