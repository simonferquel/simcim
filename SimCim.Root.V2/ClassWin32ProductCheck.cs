using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ProductCheck : GenericInfrastructureObject
    {
        public Win32ProductCheck()
        {
        }

        public Win32ProductCheck(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMCheck Check
        {
            get
            {
                CIMCheck result;
                this.GetInfrastructureObjectProperty("Check", out result);
                return result;
            }
        }

        public Win32Product Product
        {
            get
            {
                Win32Product result;
                this.GetInfrastructureObjectProperty("Product", out result);
                return result;
            }
        }
    }
}