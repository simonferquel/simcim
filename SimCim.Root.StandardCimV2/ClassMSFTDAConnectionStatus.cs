using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTDAConnectionStatus : MSFTNetSettingData
    {
        public MSFTDAConnectionStatus()
        {
        }

        public MSFTDAConnectionStatus(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Status
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Status", out result);
                return result;
            }
        }

        public System.UInt32? Substatus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Substatus", out result);
                return result;
            }
        }
    }
}