using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ComputerSystemProduct : CIMProduct
    {
        public Win32ComputerSystemProduct()
        {
        }

        public Win32ComputerSystemProduct(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String UUID
        {
            get
            {
                System.String result;
                this.GetProperty("UUID", out result);
                return result;
            }
        }
    }
}