using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetIPInterface : CIMLANEndpoint
    {
        public MSFTNetIPInterface()
        {
        }

        public MSFTNetIPInterface(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AddressFamily
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AddressFamily", out result);
                return result;
            }
        }

        public System.Byte? AdvertiseDefaultRoute
        {
            get
            {
                System.Byte? result;
                this.GetProperty("AdvertiseDefaultRoute", out result);
                return result;
            }

            set
            {
                this.SetProperty("AdvertiseDefaultRoute", value);
            }
        }

        public System.DateTime? AdvertisedRouterLifetime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("AdvertisedRouterLifetime", out result);
                return result;
            }

            set
            {
                this.SetProperty("AdvertisedRouterLifetime", value);
            }
        }

        public System.Byte? Advertising
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Advertising", out result);
                return result;
            }

            set
            {
                this.SetProperty("Advertising", value);
            }
        }

        public System.Byte? AutomaticMetric
        {
            get
            {
                System.Byte? result;
                this.GetProperty("AutomaticMetric", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutomaticMetric", value);
            }
        }

        public System.UInt32? BaseReachableTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BaseReachableTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("BaseReachableTime", value);
            }
        }

        public System.Byte? ClampMss
        {
            get
            {
                System.Byte? result;
                this.GetProperty("ClampMss", out result);
                return result;
            }

            set
            {
                this.SetProperty("ClampMss", value);
            }
        }

        public System.UInt32? CompartmentId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CompartmentId", out result);
                return result;
            }
        }

        public System.Byte? ConnectionState
        {
            get
            {
                System.Byte? result;
                this.GetProperty("ConnectionState", out result);
                return result;
            }
        }

        public System.UInt32? CurrentHopLimit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentHopLimit", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentHopLimit", value);
            }
        }

        public System.UInt32? DadRetransmitTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DadRetransmitTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("DadRetransmitTime", value);
            }
        }

        public System.UInt32? DadTransmits
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DadTransmits", out result);
                return result;
            }

            set
            {
                this.SetProperty("DadTransmits", value);
            }
        }

        public System.Byte? Dhcp
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Dhcp", out result);
                return result;
            }

            set
            {
                this.SetProperty("Dhcp", value);
            }
        }

        public System.Byte? DirectedMacWolPattern
        {
            get
            {
                System.Byte? result;
                this.GetProperty("DirectedMacWolPattern", out result);
                return result;
            }

            set
            {
                this.SetProperty("DirectedMacWolPattern", value);
            }
        }

        public System.Byte? EcnMarking
        {
            get
            {
                System.Byte? result;
                this.GetProperty("EcnMarking", out result);
                return result;
            }

            set
            {
                this.SetProperty("EcnMarking", value);
            }
        }

        public System.Byte? ForceArpNdWolPattern
        {
            get
            {
                System.Byte? result;
                this.GetProperty("ForceArpNdWolPattern", out result);
                return result;
            }

            set
            {
                this.SetProperty("ForceArpNdWolPattern", value);
            }
        }

        public System.Byte? Forwarding
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Forwarding", out result);
                return result;
            }

            set
            {
                this.SetProperty("Forwarding", value);
            }
        }

        public System.Byte? IgnoreDefaultRoutes
        {
            get
            {
                System.Byte? result;
                this.GetProperty("IgnoreDefaultRoutes", out result);
                return result;
            }

            set
            {
                this.SetProperty("IgnoreDefaultRoutes", value);
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
        }

        public System.UInt32? InterfaceIndex
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterfaceIndex", out result);
                return result;
            }
        }

        public System.UInt32? InterfaceMetric
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterfaceMetric", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterfaceMetric", value);
            }
        }

        public System.UInt32? IsolationId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IsolationId", out result);
                return result;
            }
        }

        public System.UInt64? LowestIfNetLuid
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LowestIfNetLuid", out result);
                return result;
            }
        }

        public System.Byte? ManagedAddressConfiguration
        {
            get
            {
                System.Byte? result;
                this.GetProperty("ManagedAddressConfiguration", out result);
                return result;
            }

            set
            {
                this.SetProperty("ManagedAddressConfiguration", value);
            }
        }

        public System.Byte? NeighborDiscoverySupported
        {
            get
            {
                System.Byte? result;
                this.GetProperty("NeighborDiscoverySupported", out result);
                return result;
            }
        }

        public System.Byte? NeighborUnreachabilityDetection
        {
            get
            {
                System.Byte? result;
                this.GetProperty("NeighborUnreachabilityDetection", out result);
                return result;
            }
        }

        public System.UInt32? NlMtu
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NlMtu", out result);
                return result;
            }

            set
            {
                this.SetProperty("NlMtu", value);
            }
        }

        public System.Byte? OtherStatefulConfiguration
        {
            get
            {
                System.Byte? result;
                this.GetProperty("OtherStatefulConfiguration", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherStatefulConfiguration", value);
            }
        }

        public System.UInt32? ReachableTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReachableTime", out result);
                return result;
            }
        }

        public System.UInt32? RetransmitTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RetransmitTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("RetransmitTime", value);
            }
        }

        public System.Byte? RouterDiscovery
        {
            get
            {
                System.Byte? result;
                this.GetProperty("RouterDiscovery", out result);
                return result;
            }

            set
            {
                this.SetProperty("RouterDiscovery", value);
            }
        }

        public System.Byte? Store
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Store", out result);
                return result;
            }
        }

        public System.Byte? WeakHostReceive
        {
            get
            {
                System.Byte? result;
                this.GetProperty("WeakHostReceive", out result);
                return result;
            }

            set
            {
                this.SetProperty("WeakHostReceive", value);
            }
        }

        public System.Byte? WeakHostSend
        {
            get
            {
                System.Byte? result;
                this.GetProperty("WeakHostSend", out result);
                return result;
            }

            set
            {
                this.SetProperty("WeakHostSend", value);
            }
        }
    }
}