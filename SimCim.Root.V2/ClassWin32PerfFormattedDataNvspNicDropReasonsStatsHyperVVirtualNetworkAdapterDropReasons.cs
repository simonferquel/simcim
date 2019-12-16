using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataNvspNicDropReasonsStatsHyperVVirtualNetworkAdapterDropReasons : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataNvspNicDropReasonsStatsHyperVVirtualNetworkAdapterDropReasons()
        {
        }

        public Win32PerfFormattedDataNvspNicDropReasonsStatsHyperVVirtualNetworkAdapterDropReasons(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? IncomingBridgeReserved
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingBridgeReserved", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingBridgeReserved", value);
            }
        }

        public System.UInt64? IncomingBusy
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingBusy", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingBusy", value);
            }
        }

        public System.UInt64? IncomingDhcpGuard
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingDhcpGuard", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingDhcpGuard", value);
            }
        }

        public System.UInt64? IncomingDisconnected
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingDisconnected", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingDisconnected", value);
            }
        }

        public System.UInt64? IncomingFailedDestinationListUpdate
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingFailedDestinationListUpdate", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingFailedDestinationListUpdate", value);
            }
        }

        public System.UInt64? IncomingFailedPacketFilter
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingFailedPacketFilter", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingFailedPacketFilter", value);
            }
        }

        public System.UInt64? IncomingFailedPvlanSetting
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingFailedPvlanSetting", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingFailedPvlanSetting", value);
            }
        }

        public System.UInt64? IncomingFailedSecurityPolicy
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingFailedSecurityPolicy", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingFailedSecurityPolicy", value);
            }
        }

        public System.UInt64? IncomingFiltered
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingFiltered", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingFiltered", value);
            }
        }

        public System.UInt64? IncomingFilteredIsolationUntagged
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingFilteredIsolationUntagged", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingFilteredIsolationUntagged", value);
            }
        }

        public System.UInt64? IncomingFilteredVLAN
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingFilteredVLAN", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingFilteredVLAN", value);
            }
        }

        public System.UInt64? IncomingInjectedIcmp
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingInjectedIcmp", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingInjectedIcmp", value);
            }
        }

        public System.UInt64? IncomingInvalidConfig
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingInvalidConfig", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingInvalidConfig", value);
            }
        }

        public System.UInt64? IncomingInvalidData
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingInvalidData", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingInvalidData", value);
            }
        }

        public System.UInt64? IncomingInvalidDestMac
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingInvalidDestMac", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingInvalidDestMac", value);
            }
        }

        public System.UInt64? IncomingInvalidFirstNBTooSmall
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingInvalidFirstNBTooSmall", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingInvalidFirstNBTooSmall", value);
            }
        }

        public System.UInt64? IncomingInvalidPacket
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingInvalidPacket", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingInvalidPacket", value);
            }
        }

        public System.UInt64? IncomingInvalidPDQueue
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingInvalidPDQueue", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingInvalidPDQueue", value);
            }
        }

        public System.UInt64? IncomingInvalidSourceMac
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingInvalidSourceMac", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingInvalidSourceMac", value);
            }
        }

        public System.UInt64? IncomingInvalidVlanFormat
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingInvalidVlanFormat", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingInvalidVlanFormat", value);
            }
        }

        public System.UInt64? IncomingIpsec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingIpsec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingIpsec", value);
            }
        }

        public System.UInt64? IncomingLowPowerPacketFilter
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingLowPowerPacketFilter", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingLowPowerPacketFilter", value);
            }
        }

        public System.UInt64? IncomingMacSpoofing
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingMacSpoofing", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingMacSpoofing", value);
            }
        }

        public System.UInt64? IncomingMTUMismatch
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingMTUMismatch", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingMTUMismatch", value);
            }
        }

        public System.UInt64? IncomingNativeFwdingReq
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingNativeFwdingReq", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingNativeFwdingReq", value);
            }
        }

        public System.UInt64? IncomingNicDisabled
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingNicDisabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingNicDisabled", value);
            }
        }

        public System.UInt64? IncomingNotAccepted
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingNotAccepted", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingNotAccepted", value);
            }
        }

        public System.UInt64? IncomingNotReady
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingNotReady", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingNotReady", value);
            }
        }

        public System.UInt64? IncomingQos
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingQos", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingQos", value);
            }
        }

        public System.UInt64? IncomingRequiredExtensionMissing
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingRequiredExtensionMissing", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingRequiredExtensionMissing", value);
            }
        }

        public System.UInt64? IncomingResources
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingResources", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingResources", value);
            }
        }

        public System.UInt64? IncomingRouterGuard
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingRouterGuard", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingRouterGuard", value);
            }
        }

        public System.UInt64? IncomingStormLimit
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingStormLimit", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingStormLimit", value);
            }
        }

        public System.UInt64? IncomingSwitchDataFlowDisabled
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingSwitchDataFlowDisabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingSwitchDataFlowDisabled", value);
            }
        }

        public System.UInt64? IncomingUnauthorizedMAC
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingUnauthorizedMAC", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingUnauthorizedMAC", value);
            }
        }

        public System.UInt64? IncomingUnauthorizedVLAN
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingUnauthorizedVLAN", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingUnauthorizedVLAN", value);
            }
        }

        public System.UInt64? IncomingUnknown
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingUnknown", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingUnknown", value);
            }
        }

        public System.UInt64? IncomingVirtualSubnetId
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IncomingVirtualSubnetId", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncomingVirtualSubnetId", value);
            }
        }

        public System.UInt64? OutgoingBridgeReserved
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingBridgeReserved", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingBridgeReserved", value);
            }
        }

        public System.UInt64? OutgoingBusy
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingBusy", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingBusy", value);
            }
        }

        public System.UInt64? OutgoingDhcpGuard
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingDhcpGuard", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingDhcpGuard", value);
            }
        }

        public System.UInt64? OutgoingDisconnected
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingDisconnected", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingDisconnected", value);
            }
        }

        public System.UInt64? OutgoingFailedDestinationListUpdate
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingFailedDestinationListUpdate", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingFailedDestinationListUpdate", value);
            }
        }

        public System.UInt64? OutgoingFailedPacketFilter
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingFailedPacketFilter", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingFailedPacketFilter", value);
            }
        }

        public System.UInt64? OutgoingFailedPvlanSetting
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingFailedPvlanSetting", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingFailedPvlanSetting", value);
            }
        }

        public System.UInt64? OutgoingFailedSecurityPolicy
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingFailedSecurityPolicy", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingFailedSecurityPolicy", value);
            }
        }

        public System.UInt64? OutgoingFiltered
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingFiltered", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingFiltered", value);
            }
        }

        public System.UInt64? OutgoingFilteredIsolationUntagged
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingFilteredIsolationUntagged", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingFilteredIsolationUntagged", value);
            }
        }

        public System.UInt64? OutgoingFilteredVLAN
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingFilteredVLAN", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingFilteredVLAN", value);
            }
        }

        public System.UInt64? OutgoingInjectedIcmp
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingInjectedIcmp", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingInjectedIcmp", value);
            }
        }

        public System.UInt64? OutgoingInvalidConfig
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingInvalidConfig", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingInvalidConfig", value);
            }
        }

        public System.UInt64? OutgoingInvalidData
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingInvalidData", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingInvalidData", value);
            }
        }

        public System.UInt64? OutgoingInvalidDestMac
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingInvalidDestMac", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingInvalidDestMac", value);
            }
        }

        public System.UInt64? OutgoingInvalidFirstNBTooSmall
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingInvalidFirstNBTooSmall", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingInvalidFirstNBTooSmall", value);
            }
        }

        public System.UInt64? OutgoingInvalidPacket
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingInvalidPacket", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingInvalidPacket", value);
            }
        }

        public System.UInt64? OutgoingInvalidPDQueue
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingInvalidPDQueue", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingInvalidPDQueue", value);
            }
        }

        public System.UInt64? OutgoingInvalidSourceMac
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingInvalidSourceMac", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingInvalidSourceMac", value);
            }
        }

        public System.UInt64? OutgoingInvalidVlanFormat
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingInvalidVlanFormat", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingInvalidVlanFormat", value);
            }
        }

        public System.UInt64? OutgoingIpsec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingIpsec", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingIpsec", value);
            }
        }

        public System.UInt64? OutgoingLowPowerPacketFilter
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingLowPowerPacketFilter", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingLowPowerPacketFilter", value);
            }
        }

        public System.UInt64? OutgoingMacSpoofing
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingMacSpoofing", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingMacSpoofing", value);
            }
        }

        public System.UInt64? OutgoingMTUMismatch
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingMTUMismatch", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingMTUMismatch", value);
            }
        }

        public System.UInt64? OutgoingNativeFwdingReq
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingNativeFwdingReq", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingNativeFwdingReq", value);
            }
        }

        public System.UInt64? OutgoingNicDisabled
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingNicDisabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingNicDisabled", value);
            }
        }

        public System.UInt64? OutgoingNotAccepted
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingNotAccepted", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingNotAccepted", value);
            }
        }

        public System.UInt64? OutgoingNotReady
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingNotReady", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingNotReady", value);
            }
        }

        public System.UInt64? OutgoingQos
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingQos", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingQos", value);
            }
        }

        public System.UInt64? OutgoingRequiredExtensionMissing
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingRequiredExtensionMissing", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingRequiredExtensionMissing", value);
            }
        }

        public System.UInt64? OutgoingResources
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingResources", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingResources", value);
            }
        }

        public System.UInt64? OutgoingRouterGuard
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingRouterGuard", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingRouterGuard", value);
            }
        }

        public System.UInt64? OutgoingStormLimit
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingStormLimit", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingStormLimit", value);
            }
        }

        public System.UInt64? OutgoingSwitchDataFlowDisabled
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingSwitchDataFlowDisabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingSwitchDataFlowDisabled", value);
            }
        }

        public System.UInt64? OutgoingUnauthorizedMAC
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingUnauthorizedMAC", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingUnauthorizedMAC", value);
            }
        }

        public System.UInt64? OutgoingUnauthorizedVLAN
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingUnauthorizedVLAN", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingUnauthorizedVLAN", value);
            }
        }

        public System.UInt64? OutgoingUnknown
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingUnknown", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingUnknown", value);
            }
        }

        public System.UInt64? OutgoingVirtualSubnetId
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutgoingVirtualSubnetId", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutgoingVirtualSubnetId", value);
            }
        }
    }
}