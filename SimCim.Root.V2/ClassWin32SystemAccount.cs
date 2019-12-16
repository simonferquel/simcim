using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SystemAccount : Win32Account
    {
        public Win32SystemAccount()
        {
        }

        public Win32SystemAccount(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}