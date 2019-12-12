using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ClusterShare : Win32Share
    {
        public Win32ClusterShare()
        {
        }

        public Win32ClusterShare(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ServerName
        {
            get
            {
                System.String result;
                this.GetProperty("ServerName", out result);
                return result;
            }
        }
    }
}