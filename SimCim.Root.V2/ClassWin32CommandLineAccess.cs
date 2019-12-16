using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32CommandLineAccess : CIMServiceAccessPoint
    {
        public Win32CommandLineAccess()
        {
        }

        public Win32CommandLineAccess(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CommandLine
        {
            get
            {
                System.String result;
                this.GetProperty("CommandLine", out result);
                return result;
            }
        }
    }
}