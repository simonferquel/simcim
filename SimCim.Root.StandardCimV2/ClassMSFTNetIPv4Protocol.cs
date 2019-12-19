using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetIPv4Protocol : MSFTNetBaseIPProtocol
    {
        public MSFTNetIPv4Protocol()
        {
        }

        public MSFTNetIPv4Protocol(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? MinimumMtu
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MinimumMtu", out result);
                return result;
            }

            set
            {
                this.SetProperty("MinimumMtu", value);
            }
        }
    }
}