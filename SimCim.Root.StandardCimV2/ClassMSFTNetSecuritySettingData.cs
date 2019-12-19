using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetSecuritySettingData : MSFTNetSettingData
    {
        public MSFTNetSecuritySettingData()
        {
        }

        public MSFTNetSecuritySettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AllowIPsecThroughNAT
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AllowIPsecThroughNAT", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowIPsecThroughNAT", value);
            }
        }

        public System.UInt16? CertValidationLevel
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CertValidationLevel", out result);
                return result;
            }

            set
            {
                this.SetProperty("CertValidationLevel", value);
            }
        }

        public System.UInt16? EnablePacketQueuing
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EnablePacketQueuing", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnablePacketQueuing", value);
            }
        }

        public System.UInt16? EnableStatefulFtp
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EnableStatefulFtp", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnableStatefulFtp", value);
            }
        }

        public System.UInt16? EnableStatefulPptp
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EnableStatefulPptp", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnableStatefulPptp", value);
            }
        }

        public System.UInt32? Exemptions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Exemptions", out result);
                return result;
            }

            set
            {
                this.SetProperty("Exemptions", value);
            }
        }

        public System.UInt16? KeyEncoding
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("KeyEncoding", out result);
                return result;
            }

            set
            {
                this.SetProperty("KeyEncoding", value);
            }
        }

        public System.UInt32? MaxSAIdleTimeSeconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxSAIdleTimeSeconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxSAIdleTimeSeconds", value);
            }
        }

        public System.UInt16? Profile
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Profile", out result);
                return result;
            }

            set
            {
                this.SetProperty("Profile", value);
            }
        }

        public System.String RemoteMachineTransportAuthorizationList
        {
            get
            {
                System.String result;
                this.GetProperty("RemoteMachineTransportAuthorizationList", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteMachineTransportAuthorizationList", value);
            }
        }

        public System.String RemoteMachineTunnelAuthorizationList
        {
            get
            {
                System.String result;
                this.GetProperty("RemoteMachineTunnelAuthorizationList", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteMachineTunnelAuthorizationList", value);
            }
        }

        public System.String RemoteUserTransportAuthorizationList
        {
            get
            {
                System.String result;
                this.GetProperty("RemoteUserTransportAuthorizationList", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteUserTransportAuthorizationList", value);
            }
        }

        public System.String RemoteUserTunnelAuthorizationList
        {
            get
            {
                System.String result;
                this.GetProperty("RemoteUserTunnelAuthorizationList", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteUserTunnelAuthorizationList", value);
            }
        }

        public System.UInt16? RequireFullAuthSupport
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("RequireFullAuthSupport", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequireFullAuthSupport", value);
            }
        }
    }
}