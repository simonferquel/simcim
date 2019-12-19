using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetNetworkLayerSecurityFilter : CIMFilterEntryBase
    {
        public MSFTNetNetworkLayerSecurityFilter()
        {
        }

        public MSFTNetNetworkLayerSecurityFilter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Authentication
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Authentication", out result);
                return result;
            }

            set
            {
                this.SetProperty("Authentication", value);
            }
        }

        public System.UInt16? Encryption
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Encryption", out result);
                return result;
            }

            set
            {
                this.SetProperty("Encryption", value);
            }
        }

        public System.String LocalUsers
        {
            get
            {
                System.String result;
                this.GetProperty("LocalUsers", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalUsers", value);
            }
        }

        public System.Boolean? OverrideBlockRules
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("OverrideBlockRules", out result);
                return result;
            }

            set
            {
                this.SetProperty("OverrideBlockRules", value);
            }
        }

        public System.String RemoteMachines
        {
            get
            {
                System.String result;
                this.GetProperty("RemoteMachines", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteMachines", value);
            }
        }

        public System.String RemoteUsers
        {
            get
            {
                System.String result;
                this.GetProperty("RemoteUsers", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteUsers", value);
            }
        }
    }
}