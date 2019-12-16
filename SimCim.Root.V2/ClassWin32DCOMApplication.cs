using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DCOMApplication : Win32COMApplication
    {
        public Win32DCOMApplication()
        {
        }

        public Win32DCOMApplication(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AppID
        {
            get
            {
                System.String result;
                this.GetProperty("AppID", out result);
                return result;
            }
        }
    }
}