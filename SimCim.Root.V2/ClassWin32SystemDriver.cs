using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SystemDriver : Win32BaseService
    {
        public Win32SystemDriver()
        {
        }

        public Win32SystemDriver(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}