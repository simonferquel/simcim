using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterPowerManagementOffloadRsnRekey : MSFTNetAdapterPowerManagementOffload
    {
        public MSFTNetAdapterPowerManagementOffloadRsnRekey()
        {
        }

        public MSFTNetAdapterPowerManagementOffloadRsnRekey(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte[] KCK
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("KCK", out result);
                return result;
            }

            set
            {
                this.SetProperty("KCK", value);
            }
        }

        public System.Byte[] KEK
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("KEK", out result);
                return result;
            }

            set
            {
                this.SetProperty("KEK", value);
            }
        }

        public System.UInt64? ReplayCounter
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReplayCounter", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReplayCounter", value);
            }
        }
    }
}