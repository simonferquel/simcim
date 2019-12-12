using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Refrigeration : CIMRefrigeration
    {
        public Win32Refrigeration()
        {
        }

        public Win32Refrigeration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}