using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NamedJobObjectStatistics : Win32CollectionStatistics
    {
        public Win32NamedJobObjectStatistics()
        {
        }

        public Win32NamedJobObjectStatistics(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32NamedJobObject Collection
        {
            get
            {
                Win32NamedJobObject result;
                this.GetInfrastructureObjectProperty("Collection", out result);
                return result;
            }
        }

        public new Win32NamedJobObjectActgInfo Stats
        {
            get
            {
                Win32NamedJobObjectActgInfo result;
                this.GetInfrastructureObjectProperty("Stats", out result);
                return result;
            }
        }
    }
}