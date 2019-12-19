using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetIPv6Protocol : MSFTNetBaseIPProtocol
    {
        public MSFTNetIPv6Protocol()
        {
        }

        public MSFTNetIPv6Protocol(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? MaxDadAttempts
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxDadAttempts", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxDadAttempts", value);
            }
        }

        public System.DateTime? MaxPreferredLifetime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("MaxPreferredLifetime", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxPreferredLifetime", value);
            }
        }

        public System.DateTime? MaxRandomTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("MaxRandomTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxRandomTime", value);
            }
        }

        public System.DateTime? MaxValidLifetime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("MaxValidLifetime", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxValidLifetime", value);
            }
        }

        public System.DateTime? RegenerateTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("RegenerateTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("RegenerateTime", value);
            }
        }

        public System.UInt32? UseTemporaryAddresses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UseTemporaryAddresses", out result);
                return result;
            }

            set
            {
                this.SetProperty("UseTemporaryAddresses", value);
            }
        }
    }
}