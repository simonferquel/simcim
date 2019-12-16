using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetQuickModeSA : CIMIPsecSAEndpoint
    {
        public MSFTNetQuickModeSA()
        {
        }

        public MSFTNetQuickModeSA(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String EmTargetName
        {
            get
            {
                System.String result;
                this.GetProperty("EmTargetName", out result);
                return result;
            }

            set
            {
                this.SetProperty("EmTargetName", value);
            }
        }

        public System.UInt64? ExplicitCredentials
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ExplicitCredentials", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExplicitCredentials", value);
            }
        }

        public System.UInt32? FirstCipherAlgorithm
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FirstCipherAlgorithm", out result);
                return result;
            }

            set
            {
                this.SetProperty("FirstCipherAlgorithm", value);
            }
        }

        public System.UInt32? FirstIntegrityAlgorithm
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FirstIntegrityAlgorithm", out result);
                return result;
            }

            set
            {
                this.SetProperty("FirstIntegrityAlgorithm", value);
            }
        }

        public System.UInt32? FirstTransformType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FirstTransformType", out result);
                return result;
            }

            set
            {
                this.SetProperty("FirstTransformType", value);
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

        public System.String InterfaceAlias
        {
            get
            {
                System.String result;
                this.GetProperty("InterfaceAlias", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterfaceAlias", value);
            }
        }

        public System.Byte? IpProtocol
        {
            get
            {
                System.Byte? result;
                this.GetProperty("IpProtocol", out result);
                return result;
            }

            set
            {
                this.SetProperty("IpProtocol", value);
            }
        }

        public System.UInt64? LifetimePackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LifetimePackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("LifetimePackets", value);
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

        public System.UInt16? LocalPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LocalPort", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalPort", value);
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

        public System.UInt64? MmSaId
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MmSaId", out result);
                return result;
            }

            set
            {
                this.SetProperty("MmSaId", value);
            }
        }

        public System.String MmTargetName
        {
            get
            {
                System.String result;
                this.GetProperty("MmTargetName", out result);
                return result;
            }

            set
            {
                this.SetProperty("MmTargetName", value);
            }
        }

        public System.UInt32? NapContext
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NapContext", out result);
                return result;
            }

            set
            {
                this.SetProperty("NapContext", value);
            }
        }

        public System.UInt32? NdAllowClearTimeoutSeconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NdAllowClearTimeoutSeconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("NdAllowClearTimeoutSeconds", value);
            }
        }

        public System.String PeerV4PrivateAddress
        {
            get
            {
                System.String result;
                this.GetProperty("PeerV4PrivateAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("PeerV4PrivateAddress", value);
            }
        }

        public System.UInt32? PfsGroupId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PfsGroupId", out result);
                return result;
            }

            set
            {
                this.SetProperty("PfsGroupId", value);
            }
        }

        public System.UInt32? QmSaId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QmSaId", out result);
                return result;
            }

            set
            {
                this.SetProperty("QmSaId", value);
            }
        }

        public System.UInt64? QuickModeFilterId
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("QuickModeFilterId", out result);
                return result;
            }

            set
            {
                this.SetProperty("QuickModeFilterId", value);
            }
        }

        public System.UInt64? RealIfProfileId
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RealIfProfileId", out result);
                return result;
            }

            set
            {
                this.SetProperty("RealIfProfileId", value);
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

        public System.UInt16? RemotePort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("RemotePort", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemotePort", value);
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

        public System.UInt32? SecondCipherAlgorithm
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SecondCipherAlgorithm", out result);
                return result;
            }

            set
            {
                this.SetProperty("SecondCipherAlgorithm", value);
            }
        }

        public System.UInt32? SecondIntegrityAlgorithm
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SecondIntegrityAlgorithm", out result);
                return result;
            }

            set
            {
                this.SetProperty("SecondIntegrityAlgorithm", value);
            }
        }

        public System.UInt32? SecondSPI
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SecondSPI", out result);
                return result;
            }

            set
            {
                this.SetProperty("SecondSPI", value);
            }
        }

        public System.UInt32? SecondTransformType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SecondTransformType", out result);
                return result;
            }

            set
            {
                this.SetProperty("SecondTransformType", value);
            }
        }

        public System.UInt64? TrafficLuid
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TrafficLuid", out result);
                return result;
            }

            set
            {
                this.SetProperty("TrafficLuid", value);
            }
        }

        public System.UInt64? TrafficSelectorId
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TrafficSelectorId", out result);
                return result;
            }

            set
            {
                this.SetProperty("TrafficSelectorId", value);
            }
        }

        public System.String TransportLayerFilterName
        {
            get
            {
                System.String result;
                this.GetProperty("TransportLayerFilterName", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransportLayerFilterName", value);
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