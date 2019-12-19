using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetMainModeSA : CIMIKESAEndpoint
    {
        public MSFTNetMainModeSA()
        {
        }

        public MSFTNetMainModeSA(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? ExtendedFilterId
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ExtendedFilterId", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExtendedFilterId", value);
            }
        }

        public System.String IkePolicyKey
        {
            get
            {
                System.String result;
                this.GetProperty("IkePolicyKey", out result);
                return result;
            }

            set
            {
                this.SetProperty("IkePolicyKey", value);
            }
        }

        public System.UInt16? KeyModule
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("KeyModule", out result);
                return result;
            }

            set
            {
                this.SetProperty("KeyModule", value);
            }
        }

        public System.String LocalEndpoint
        {
            get
            {
                System.String result;
                this.GetProperty("LocalEndpoint", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalEndpoint", value);
            }
        }

        public MSFTNetIPsecIdentity LocalFirstId
        {
            get
            {
                MSFTNetIPsecIdentity result;
                this.GetInfrastructureObjectProperty("LocalFirstId", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalFirstId", value);
            }
        }

        public MSFTNetIPsecIdentity LocalSecondId
        {
            get
            {
                MSFTNetIPsecIdentity result;
                this.GetInfrastructureObjectProperty("LocalSecondId", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalSecondId", value);
            }
        }

        public System.UInt16? LocalUdpEncapsulationPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LocalUdpEncapsulationPort", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalUdpEncapsulationPort", value);
            }
        }

        public System.UInt32? MaxQMSAs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxQMSAs", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxQMSAs", value);
            }
        }

        public System.String OtherGroupId
        {
            get
            {
                System.String result;
                this.GetProperty("OtherGroupId", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherGroupId", value);
            }
        }

        public System.String RemoteEndpoint
        {
            get
            {
                System.String result;
                this.GetProperty("RemoteEndpoint", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteEndpoint", value);
            }
        }

        public MSFTNetIPsecIdentity RemoteFirstId
        {
            get
            {
                MSFTNetIPsecIdentity result;
                this.GetInfrastructureObjectProperty("RemoteFirstId", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteFirstId", value);
            }
        }

        public MSFTNetIPsecIdentity RemoteSecondId
        {
            get
            {
                MSFTNetIPsecIdentity result;
                this.GetInfrastructureObjectProperty("RemoteSecondId", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteSecondId", value);
            }
        }

        public System.UInt16? RemoteUdpEncapsulationPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("RemoteUdpEncapsulationPort", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteUdpEncapsulationPort", value);
            }
        }

        public System.UInt64? VirtualIfTunnelId
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualIfTunnelId", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualIfTunnelId", value);
            }
        }
    }
}