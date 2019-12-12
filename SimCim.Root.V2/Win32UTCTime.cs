using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32UTCTime : Win32CurrentTime
    {
        public Win32UTCTime()
        {
        }

        public Win32UTCTime(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}