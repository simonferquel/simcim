using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class NTEventlogProviderConfig : GenericInfrastructureObject
    {
        public NTEventlogProviderConfig()
        {
        }

        public NTEventlogProviderConfig(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.DateTime? LastBootUpTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastBootUpTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("LastBootUpTime", value);
            }
        }
    }
}