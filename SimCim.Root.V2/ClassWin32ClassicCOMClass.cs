using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ClassicCOMClass : Win32COMClass
    {
        public Win32ClassicCOMClass()
        {
        }

        public Win32ClassicCOMClass(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ComponentId
        {
            get
            {
                System.String result;
                this.GetProperty("ComponentId", out result);
                return result;
            }
        }
    }
}