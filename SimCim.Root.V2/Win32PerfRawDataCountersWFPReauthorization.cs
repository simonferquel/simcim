using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersWFPReauthorization : Win32PerfRawData
    {
        public Win32PerfRawDataCountersWFPReauthorization()
        {
        }

        public Win32PerfRawDataCountersWFPReauthorization(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? FamilyV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FamilyV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FamilyV4", value);
            }
        }

        public System.UInt64? FamilyV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FamilyV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FamilyV6", value);
            }
        }

        public System.UInt64? Inbound
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Inbound", out result);
                return result;
            }

            set
            {
                this.SetProperty("Inbound", value);
            }
        }

        public System.UInt64? Outbound
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Outbound", out result);
                return result;
            }

            set
            {
                this.SetProperty("Outbound", value);
            }
        }

        public System.UInt64? ProtocolICMP
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProtocolICMP", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProtocolICMP", value);
            }
        }

        public System.UInt64? ProtocolICMP6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProtocolICMP6", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProtocolICMP6", value);
            }
        }

        public System.UInt64? ProtocolIPv4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProtocolIPv4", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProtocolIPv4", value);
            }
        }

        public System.UInt64? ProtocolIPv6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProtocolIPv6", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProtocolIPv6", value);
            }
        }

        public System.UInt64? ProtocolOther
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProtocolOther", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProtocolOther", value);
            }
        }

        public System.UInt64? ProtocolTCP
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProtocolTCP", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProtocolTCP", value);
            }
        }

        public System.UInt64? ProtocolUDP
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProtocolUDP", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProtocolUDP", value);
            }
        }

        public System.UInt64? ReasonClassifyCompletion
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReasonClassifyCompletion", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReasonClassifyCompletion", value);
            }
        }

        public System.UInt64? ReasonEDPPolicyChanged
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReasonEDPPolicyChanged", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReasonEDPPolicyChanged", value);
            }
        }

        public System.UInt64? ReasonIPSecPropertiesChanged
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReasonIPSecPropertiesChanged", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReasonIPSecPropertiesChanged", value);
            }
        }

        public System.UInt64? ReasonMidStreamInspection
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReasonMidStreamInspection", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReasonMidStreamInspection", value);
            }
        }

        public System.UInt64? ReasonNewArrivalInterface
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReasonNewArrivalInterface", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReasonNewArrivalInterface", value);
            }
        }

        public System.UInt64? ReasonNewInboundMCastBCastPacket
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReasonNewInboundMCastBCastPacket", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReasonNewInboundMCastBCastPacket", value);
            }
        }

        public System.UInt64? ReasonNewNextHopInterface
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReasonNewNextHopInterface", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReasonNewNextHopInterface", value);
            }
        }

        public System.UInt64? ReasonPolicyChange
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReasonPolicyChange", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReasonPolicyChange", value);
            }
        }

        public System.UInt64? ReasonPreclassifyLocalAddressDimensionPolicyChanged
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReasonPreclassifyLocalAddressDimensionPolicyChanged", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReasonPreclassifyLocalAddressDimensionPolicyChanged", value);
            }
        }

        public System.UInt64? ReasonPreclassifyLocalPortDimensionPolicyChanged
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReasonPreclassifyLocalPortDimensionPolicyChanged", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReasonPreclassifyLocalPortDimensionPolicyChanged", value);
            }
        }

        public System.UInt64? ReasonPreclassifyRemoteAddressDimensionPolicyChanged
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReasonPreclassifyRemoteAddressDimensionPolicyChanged", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReasonPreclassifyRemoteAddressDimensionPolicyChanged", value);
            }
        }

        public System.UInt64? ReasonPreclassifyRemotePortDimensionPolicyChanged
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReasonPreclassifyRemotePortDimensionPolicyChanged", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReasonPreclassifyRemotePortDimensionPolicyChanged", value);
            }
        }

        public System.UInt64? ReasonProfileCrossing
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReasonProfileCrossing", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReasonProfileCrossing", value);
            }
        }

        public System.UInt64? ReasonProxyHandleChanged
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReasonProxyHandleChanged", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReasonProxyHandleChanged", value);
            }
        }

        public System.UInt64? ReasonSocketPropertyChanged
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReasonSocketPropertyChanged", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReasonSocketPropertyChanged", value);
            }
        }
    }
}