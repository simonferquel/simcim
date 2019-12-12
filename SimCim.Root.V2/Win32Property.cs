using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Property : Win32MSIResource
    {
        public Win32Property()
        {
        }

        public Win32Property(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ProductCode
        {
            get
            {
                System.String result;
                this.GetProperty("ProductCode", out result);
                return result;
            }
        }

        public System.String Property
        {
            get
            {
                System.String result;
                this.GetProperty("Property", out result);
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