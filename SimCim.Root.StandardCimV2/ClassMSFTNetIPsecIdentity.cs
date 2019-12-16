using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetIPsecIdentity : GenericInfrastructureObject
    {
        public MSFTNetIPsecIdentity()
        {
        }

        public MSFTNetIPsecIdentity(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AuthenticationMethod
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AuthenticationMethod", out result);
                return result;
            }

            set
            {
                this.SetProperty("AuthenticationMethod", value);
            }
        }

        public System.UInt32? Flags
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Flags", out result);
                return result;
            }

            set
            {
                this.SetProperty("Flags", value);
            }
        }

        public System.String Identity
        {
            get
            {
                System.String result;
                this.GetProperty("Identity", out result);
                return result;
            }

            set
            {
                this.SetProperty("Identity", value);
            }
        }

        public System.UInt32? ImpersonationType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ImpersonationType", out result);
                return result;
            }

            set
            {
                this.SetProperty("ImpersonationType", value);
            }
        }
    }
}