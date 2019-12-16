using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataHvStatsHyperVHypervisorRootVirtualProcessor : Win32PerfRawData
    {
        public Win32PerfRawDataHvStatsHyperVHypervisorRootVirtualProcessor()
        {
        }

        public Win32PerfRawDataHvStatsHyperVHypervisorRootVirtualProcessor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AddressDomainFlushesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AddressDomainFlushesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AddressDomainFlushesPersec", value);
            }
        }

        public System.UInt64? AddressSpaceEvictionsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AddressSpaceEvictionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AddressSpaceEvictionsPersec", value);
            }
        }

        public System.UInt64? AddressSpaceFlushesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AddressSpaceFlushesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AddressSpaceFlushesPersec", value);
            }
        }

        public System.UInt64? AddressSpaceSwitchesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AddressSpaceSwitchesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AddressSpaceSwitchesPersec", value);
            }
        }

        public System.UInt64? APICEOIAccessesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("APICEOIAccessesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("APICEOIAccessesPersec", value);
            }
        }

        public System.UInt64? APICIPIsSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("APICIPIsSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("APICIPIsSentPersec", value);
            }
        }

        public System.UInt64? APICMMIOAccessesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("APICMMIOAccessesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("APICMMIOAccessesPersec", value);
            }
        }

        public System.UInt64? APICSelfIPIsSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("APICSelfIPIsSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("APICSelfIPIsSentPersec", value);
            }
        }

        public System.UInt64? APICTPRAccessesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("APICTPRAccessesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("APICTPRAccessesPersec", value);
            }
        }

        public System.UInt64? ControlRegisterAccessesCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ControlRegisterAccessesCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("ControlRegisterAccessesCost", value);
            }
        }

        public System.UInt64? ControlRegisterAccessesCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ControlRegisterAccessesCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("ControlRegisterAccessesCost_Base", value);
            }
        }

        public System.UInt64? ControlRegisterAccessesForwardedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ControlRegisterAccessesForwardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ControlRegisterAccessesForwardedPersec", value);
            }
        }

        public System.UInt64? ControlRegisterAccessesForwardingCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ControlRegisterAccessesForwardingCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("ControlRegisterAccessesForwardingCost", value);
            }
        }

        public System.UInt64? ControlRegisterAccessesForwardingCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ControlRegisterAccessesForwardingCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("ControlRegisterAccessesForwardingCost_Base", value);
            }
        }

        public System.UInt64? ControlRegisterAccessesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ControlRegisterAccessesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ControlRegisterAccessesPersec", value);
            }
        }

        public System.UInt64? CPUIDInstructionsCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CPUIDInstructionsCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("CPUIDInstructionsCost", value);
            }
        }

        public System.UInt64? CPUIDInstructionsCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CPUIDInstructionsCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("CPUIDInstructionsCost_Base", value);
            }
        }

        public System.UInt64? CPUIDInstructionsForwardedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CPUIDInstructionsForwardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CPUIDInstructionsForwardedPersec", value);
            }
        }

        public System.UInt64? CPUIDInstructionsForwardingCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CPUIDInstructionsForwardingCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("CPUIDInstructionsForwardingCost", value);
            }
        }

        public System.UInt64? CPUIDInstructionsForwardingCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CPUIDInstructionsForwardingCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("CPUIDInstructionsForwardingCost_Base", value);
            }
        }

        public System.UInt64? CPUIDInstructionsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CPUIDInstructionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CPUIDInstructionsPersec", value);
            }
        }

        public System.UInt64? CPUWaitTimePerDispatch
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CPUWaitTimePerDispatch", out result);
                return result;
            }

            set
            {
                this.SetProperty("CPUWaitTimePerDispatch", value);
            }
        }

        public System.UInt64? CPUWaitTimePerDispatchBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CPUWaitTimePerDispatch_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("CPUWaitTimePerDispatch_Base", value);
            }
        }

        public System.UInt64? DebugRegisterAccessesCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DebugRegisterAccessesCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("DebugRegisterAccessesCost", value);
            }
        }

        public System.UInt64? DebugRegisterAccessesCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DebugRegisterAccessesCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("DebugRegisterAccessesCost_Base", value);
            }
        }

        public System.UInt64? DebugRegisterAccessesForwardedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DebugRegisterAccessesForwardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DebugRegisterAccessesForwardedPersec", value);
            }
        }

        public System.UInt64? DebugRegisterAccessesForwardingCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DebugRegisterAccessesForwardingCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("DebugRegisterAccessesForwardingCost", value);
            }
        }

        public System.UInt64? DebugRegisterAccessesForwardingCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DebugRegisterAccessesForwardingCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("DebugRegisterAccessesForwardingCost_Base", value);
            }
        }

        public System.UInt64? DebugRegisterAccessesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DebugRegisterAccessesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DebugRegisterAccessesPersec", value);
            }
        }

        public System.UInt64? EmulatedInstructionsCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EmulatedInstructionsCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("EmulatedInstructionsCost", value);
            }
        }

        public System.UInt64? EmulatedInstructionsCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EmulatedInstructionsCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("EmulatedInstructionsCost_Base", value);
            }
        }

        public System.UInt64? EmulatedInstructionsForwardedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EmulatedInstructionsForwardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("EmulatedInstructionsForwardedPersec", value);
            }
        }

        public System.UInt64? EmulatedInstructionsForwardingCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EmulatedInstructionsForwardingCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("EmulatedInstructionsForwardingCost", value);
            }
        }

        public System.UInt64? EmulatedInstructionsForwardingCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EmulatedInstructionsForwardingCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("EmulatedInstructionsForwardingCost_Base", value);
            }
        }

        public System.UInt64? EmulatedInstructionsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EmulatedInstructionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("EmulatedInstructionsPersec", value);
            }
        }

        public System.UInt64? ExtendedHypercallInterceptMessagesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ExtendedHypercallInterceptMessagesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExtendedHypercallInterceptMessagesPersec", value);
            }
        }

        public System.UInt64? ExtendedHypercallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ExtendedHypercallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExtendedHypercallsPersec", value);
            }
        }

        public System.UInt64? ExternalInterruptsCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ExternalInterruptsCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExternalInterruptsCost", value);
            }
        }

        public System.UInt64? ExternalInterruptsCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ExternalInterruptsCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExternalInterruptsCost_Base", value);
            }
        }

        public System.UInt64? ExternalInterruptsForwardedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ExternalInterruptsForwardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExternalInterruptsForwardedPersec", value);
            }
        }

        public System.UInt64? ExternalInterruptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ExternalInterruptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExternalInterruptsPersec", value);
            }
        }

        public System.UInt64? FlushPhysicalAddressListHypercallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FlushPhysicalAddressListHypercallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FlushPhysicalAddressListHypercallsPersec", value);
            }
        }

        public System.UInt64? FlushPhysicalAddressSpaceHypercallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FlushPhysicalAddressSpaceHypercallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FlushPhysicalAddressSpaceHypercallsPersec", value);
            }
        }

        public System.UInt64? GlobalGVARangeFlushesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("GlobalGVARangeFlushesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("GlobalGVARangeFlushesPersec", value);
            }
        }

        public System.UInt64? GlobalIOTLBFlushCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("GlobalIOTLBFlushCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("GlobalIOTLBFlushCost", value);
            }
        }

        public System.UInt64? GlobalIOTLBFlushCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("GlobalIOTLBFlushCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("GlobalIOTLBFlushCost_Base", value);
            }
        }

        public System.UInt64? GlobalIOTLBFlushesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("GlobalIOTLBFlushesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("GlobalIOTLBFlushesPersec", value);
            }
        }

        public System.UInt64? GPASpaceHypercallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("GPASpaceHypercallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("GPASpaceHypercallsPersec", value);
            }
        }

        public System.UInt64? GuestPageTableMapsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("GuestPageTableMapsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("GuestPageTableMapsPersec", value);
            }
        }

        public System.UInt64? HardwareInterruptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HardwareInterruptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("HardwareInterruptsPersec", value);
            }
        }

        public System.UInt64? HLTInstructionsCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HLTInstructionsCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("HLTInstructionsCost", value);
            }
        }

        public System.UInt64? HLTInstructionsCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HLTInstructionsCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("HLTInstructionsCost_Base", value);
            }
        }

        public System.UInt64? HLTInstructionsForwardedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HLTInstructionsForwardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("HLTInstructionsForwardedPersec", value);
            }
        }

        public System.UInt64? HLTInstructionsForwardingCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HLTInstructionsForwardingCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("HLTInstructionsForwardingCost", value);
            }
        }

        public System.UInt64? HLTInstructionsForwardingCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HLTInstructionsForwardingCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("HLTInstructionsForwardingCost_Base", value);
            }
        }

        public System.UInt64? HLTInstructionsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HLTInstructionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("HLTInstructionsPersec", value);
            }
        }

        public System.UInt64? HypercallsCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HypercallsCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("HypercallsCost", value);
            }
        }

        public System.UInt64? HypercallsCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HypercallsCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("HypercallsCost_Base", value);
            }
        }

        public System.UInt64? HypercallsForwardedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HypercallsForwardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("HypercallsForwardedPersec", value);
            }
        }

        public System.UInt64? HypercallsForwardingCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HypercallsForwardingCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("HypercallsForwardingCost", value);
            }
        }

        public System.UInt64? HypercallsForwardingCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HypercallsForwardingCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("HypercallsForwardingCost_Base", value);
            }
        }

        public System.UInt64? HypercallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HypercallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("HypercallsPersec", value);
            }
        }

        public System.UInt64? InvEptAllContextEmulationInterceptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InvEptAllContextEmulationInterceptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InvEptAllContextEmulationInterceptsPersec", value);
            }
        }

        public System.UInt64? InvEptAllContextInstructionEmulationCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InvEptAllContextInstructionEmulationCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("InvEptAllContextInstructionEmulationCost", value);
            }
        }

        public System.UInt64? InvEptAllContextInstructionEmulationCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InvEptAllContextInstructionEmulationCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("InvEptAllContextInstructionEmulationCost_Base", value);
            }
        }

        public System.UInt64? InvEptSingleContextEmulationInterceptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InvEptSingleContextEmulationInterceptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InvEptSingleContextEmulationInterceptsPersec", value);
            }
        }

        public System.UInt64? InvEptSingleContextInstructionEmulationCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InvEptSingleContextInstructionEmulationCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("InvEptSingleContextInstructionEmulationCost", value);
            }
        }

        public System.UInt64? InvEptSingleContextInstructionEmulationCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InvEptSingleContextInstructionEmulationCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("InvEptSingleContextInstructionEmulationCost_Base", value);
            }
        }

        public System.UInt64? InvVpidAllContextEmulationInterceptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InvVpidAllContextEmulationInterceptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InvVpidAllContextEmulationInterceptsPersec", value);
            }
        }

        public System.UInt64? InvVpidAllContextInstructionEmulationCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InvVpidAllContextInstructionEmulationCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("InvVpidAllContextInstructionEmulationCost", value);
            }
        }

        public System.UInt64? InvVpidAllContextInstructionEmulationCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InvVpidAllContextInstructionEmulationCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("InvVpidAllContextInstructionEmulationCost_Base", value);
            }
        }

        public System.UInt64? InvVpidSingleAddressEmulationInterceptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InvVpidSingleAddressEmulationInterceptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InvVpidSingleAddressEmulationInterceptsPersec", value);
            }
        }

        public System.UInt64? InvVpidSingleAddressInstructionEmulationCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InvVpidSingleAddressInstructionEmulationCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("InvVpidSingleAddressInstructionEmulationCost", value);
            }
        }

        public System.UInt64? InvVpidSingleAddressInstructionEmulationCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InvVpidSingleAddressInstructionEmulationCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("InvVpidSingleAddressInstructionEmulationCost_Base", value);
            }
        }

        public System.UInt64? InvVpidSingleContextEmulationInterceptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InvVpidSingleContextEmulationInterceptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InvVpidSingleContextEmulationInterceptsPersec", value);
            }
        }

        public System.UInt64? InvVpidSingleContextInstructionEmulationCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InvVpidSingleContextInstructionEmulationCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("InvVpidSingleContextInstructionEmulationCost", value);
            }
        }

        public System.UInt64? InvVpidSingleContextInstructionEmulationCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InvVpidSingleContextInstructionEmulationCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("InvVpidSingleContextInstructionEmulationCost_Base", value);
            }
        }

        public System.UInt64? IOInstructionsCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOInstructionsCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOInstructionsCost", value);
            }
        }

        public System.UInt64? IOInstructionsCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOInstructionsCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOInstructionsCost_Base", value);
            }
        }

        public System.UInt64? IOInstructionsForwardedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOInstructionsForwardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOInstructionsForwardedPersec", value);
            }
        }

        public System.UInt64? IOInstructionsForwardingCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOInstructionsForwardingCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOInstructionsForwardingCost", value);
            }
        }

        public System.UInt64? IOInstructionsForwardingCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOInstructionsForwardingCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOInstructionsForwardingCost_Base", value);
            }
        }

        public System.UInt64? IOInstructionsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOInstructionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOInstructionsPersec", value);
            }
        }

        public System.UInt64? IOInterceptMessagesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOInterceptMessagesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOInterceptMessagesPersec", value);
            }
        }

        public System.UInt64? LargePageTLBFillsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LargePageTLBFillsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LargePageTLBFillsPersec", value);
            }
        }

        public System.UInt64? LocalFlushedGVARangesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LocalFlushedGVARangesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalFlushedGVARangesPersec", value);
            }
        }

        public System.UInt64? LocalIOTLBFlushCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LocalIOTLBFlushCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalIOTLBFlushCost", value);
            }
        }

        public System.UInt64? LocalIOTLBFlushCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LocalIOTLBFlushCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalIOTLBFlushCost_Base", value);
            }
        }

        public System.UInt64? LocalIOTLBFlushesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LocalIOTLBFlushesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalIOTLBFlushesPersec", value);
            }
        }

        public System.UInt64? LogicalProcessorDispatchesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LogicalProcessorDispatchesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogicalProcessorDispatchesPersec", value);
            }
        }

        public System.UInt64? LogicalProcessorHypercallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LogicalProcessorHypercallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogicalProcessorHypercallsPersec", value);
            }
        }

        public System.UInt64? LogicalProcessorMigrationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LogicalProcessorMigrationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogicalProcessorMigrationsPersec", value);
            }
        }

        public System.UInt64? LongSpinWaitHypercallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LongSpinWaitHypercallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LongSpinWaitHypercallsPersec", value);
            }
        }

        public System.UInt64? MBECNestedPageTableSwitchesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MBECNestedPageTableSwitchesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MBECNestedPageTableSwitchesPersec", value);
            }
        }

        public System.UInt64? MemoryInterceptMessagesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MemoryInterceptMessagesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MemoryInterceptMessagesPersec", value);
            }
        }

        public System.UInt64? MSRAccessesCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MSRAccessesCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("MSRAccessesCost", value);
            }
        }

        public System.UInt64? MSRAccessesCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MSRAccessesCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("MSRAccessesCost_Base", value);
            }
        }

        public System.UInt64? MSRAccessesForwardedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MSRAccessesForwardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MSRAccessesForwardedPersec", value);
            }
        }

        public System.UInt64? MSRAccessesForwardingCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MSRAccessesForwardingCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("MSRAccessesForwardingCost", value);
            }
        }

        public System.UInt64? MSRAccessesForwardingCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MSRAccessesForwardingCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("MSRAccessesForwardingCost_Base", value);
            }
        }

        public System.UInt64? MSRAccessesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MSRAccessesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MSRAccessesPersec", value);
            }
        }

        public System.UInt64? MWAITInstructionsCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MWAITInstructionsCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("MWAITInstructionsCost", value);
            }
        }

        public System.UInt64? MWAITInstructionsCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MWAITInstructionsCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("MWAITInstructionsCost_Base", value);
            }
        }

        public System.UInt64? MWAITInstructionsForwardedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MWAITInstructionsForwardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MWAITInstructionsForwardedPersec", value);
            }
        }

        public System.UInt64? MWAITInstructionsForwardingCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MWAITInstructionsForwardingCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("MWAITInstructionsForwardingCost", value);
            }
        }

        public System.UInt64? MWAITInstructionsForwardingCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MWAITInstructionsForwardingCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("MWAITInstructionsForwardingCost_Base", value);
            }
        }

        public System.UInt64? MWAITInstructionsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MWAITInstructionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MWAITInstructionsPersec", value);
            }
        }

        public System.UInt64? NestedPageFaultInterceptsCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NestedPageFaultInterceptsCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("NestedPageFaultInterceptsCost", value);
            }
        }

        public System.UInt64? NestedPageFaultInterceptsCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NestedPageFaultInterceptsCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("NestedPageFaultInterceptsCost_Base", value);
            }
        }

        public System.UInt64? NestedPageFaultInterceptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NestedPageFaultInterceptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NestedPageFaultInterceptsPersec", value);
            }
        }

        public System.UInt64? NestedSLATHardPageFaultsCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NestedSLATHardPageFaultsCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("NestedSLATHardPageFaultsCost", value);
            }
        }

        public System.UInt64? NestedSLATHardPageFaultsCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NestedSLATHardPageFaultsCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("NestedSLATHardPageFaultsCost_Base", value);
            }
        }

        public System.UInt64? NestedSLATHardPageFaultsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NestedSLATHardPageFaultsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NestedSLATHardPageFaultsPersec", value);
            }
        }

        public System.UInt64? NestedSLATSoftPageFaultsCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NestedSLATSoftPageFaultsCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("NestedSLATSoftPageFaultsCost", value);
            }
        }

        public System.UInt64? NestedSLATSoftPageFaultsCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NestedSLATSoftPageFaultsCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("NestedSLATSoftPageFaultsCost_Base", value);
            }
        }

        public System.UInt64? NestedSLATSoftPageFaultsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NestedSLATSoftPageFaultsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NestedSLATSoftPageFaultsPersec", value);
            }
        }

        public System.UInt64? NestedTLBPageTableEvictionsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NestedTLBPageTableEvictionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NestedTLBPageTableEvictionsPersec", value);
            }
        }

        public System.UInt64? NestedTLBPageTableReclamationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NestedTLBPageTableReclamationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NestedTLBPageTableReclamationsPersec", value);
            }
        }

        public System.UInt64? NestedVMEntriesCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NestedVMEntriesCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("NestedVMEntriesCost", value);
            }
        }

        public System.UInt64? NestedVMEntriesCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NestedVMEntriesCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("NestedVMEntriesCost_Base", value);
            }
        }

        public System.UInt64? NestedVMEntriesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NestedVMEntriesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NestedVMEntriesPersec", value);
            }
        }

        public System.UInt64? NMIInterruptsCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NMIInterruptsCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("NMIInterruptsCost", value);
            }
        }

        public System.UInt64? NMIInterruptsCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NMIInterruptsCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("NMIInterruptsCost_Base", value);
            }
        }

        public System.UInt64? NMIInterruptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NMIInterruptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NMIInterruptsPersec", value);
            }
        }

        public System.UInt64? OtherHypercallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OtherHypercallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherHypercallsPersec", value);
            }
        }

        public System.UInt64? OtherInterceptsCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OtherInterceptsCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherInterceptsCost", value);
            }
        }

        public System.UInt64? OtherInterceptsCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OtherInterceptsCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherInterceptsCost_Base", value);
            }
        }

        public System.UInt64? OtherInterceptsForwardedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OtherInterceptsForwardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherInterceptsForwardedPersec", value);
            }
        }

        public System.UInt64? OtherInterceptsForwardingCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OtherInterceptsForwardingCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherInterceptsForwardingCost", value);
            }
        }

        public System.UInt64? OtherInterceptsForwardingCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OtherInterceptsForwardingCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherInterceptsForwardingCost_Base", value);
            }
        }

        public System.UInt64? OtherInterceptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OtherInterceptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherInterceptsPersec", value);
            }
        }

        public System.UInt64? OtherMessagesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OtherMessagesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherMessagesPersec", value);
            }
        }

        public System.UInt64? OtherReflectedGuestExceptionsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OtherReflectedGuestExceptionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherReflectedGuestExceptionsPersec", value);
            }
        }

        public System.UInt64? PageFaultInterceptsCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageFaultInterceptsCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageFaultInterceptsCost", value);
            }
        }

        public System.UInt64? PageFaultInterceptsCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageFaultInterceptsCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageFaultInterceptsCost_Base", value);
            }
        }

        public System.UInt64? PageFaultInterceptsForwardedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageFaultInterceptsForwardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageFaultInterceptsForwardedPersec", value);
            }
        }

        public System.UInt64? PageFaultInterceptsForwardingCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageFaultInterceptsForwardingCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageFaultInterceptsForwardingCost", value);
            }
        }

        public System.UInt64? PageFaultInterceptsForwardingCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageFaultInterceptsForwardingCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageFaultInterceptsForwardingCost_Base", value);
            }
        }

        public System.UInt64? PageFaultInterceptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageFaultInterceptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageFaultInterceptsPersec", value);
            }
        }

        public System.UInt64? PageInvalidationsCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageInvalidationsCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageInvalidationsCost", value);
            }
        }

        public System.UInt64? PageInvalidationsCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageInvalidationsCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageInvalidationsCost_Base", value);
            }
        }

        public System.UInt64? PageInvalidationsForwardedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageInvalidationsForwardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageInvalidationsForwardedPersec", value);
            }
        }

        public System.UInt64? PageInvalidationsForwardingCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageInvalidationsForwardingCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageInvalidationsForwardingCost", value);
            }
        }

        public System.UInt64? PageInvalidationsForwardingCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageInvalidationsForwardingCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageInvalidationsForwardingCost_Base", value);
            }
        }

        public System.UInt64? PageInvalidationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageInvalidationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageInvalidationsPersec", value);
            }
        }

        public System.UInt64? PageScansPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageScansPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageScansPersec", value);
            }
        }

        public System.UInt64? PageTableAllocationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageTableAllocationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageTableAllocationsPersec", value);
            }
        }

        public System.UInt64? PageTableEvictionsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageTableEvictionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageTableEvictionsPersec", value);
            }
        }

        public System.UInt64? PageTableReclamationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageTableReclamationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageTableReclamationsPersec", value);
            }
        }

        public System.UInt64? PageTableResetsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageTableResetsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageTableResetsPersec", value);
            }
        }

        public System.UInt64? PageTableValidationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageTableValidationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageTableValidationsPersec", value);
            }
        }

        public System.UInt64? PageTableWriteInterceptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageTableWriteInterceptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageTableWriteInterceptsPersec", value);
            }
        }

        public System.UInt64? PendingInterruptsCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PendingInterruptsCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("PendingInterruptsCost", value);
            }
        }

        public System.UInt64? PendingInterruptsCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PendingInterruptsCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PendingInterruptsCost_Base", value);
            }
        }

        public System.UInt64? PendingInterruptsForwardedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PendingInterruptsForwardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PendingInterruptsForwardedPersec", value);
            }
        }

        public System.UInt64? PendingInterruptsForwardingCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PendingInterruptsForwardingCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("PendingInterruptsForwardingCost", value);
            }
        }

        public System.UInt64? PendingInterruptsForwardingCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PendingInterruptsForwardingCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PendingInterruptsForwardingCost_Base", value);
            }
        }

        public System.UInt64? PendingInterruptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PendingInterruptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PendingInterruptsPersec", value);
            }
        }

        public System.UInt64? PercentGuestIdleTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentGuestIdleTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentGuestIdleTime", value);
            }
        }

        public System.UInt64? PercentGuestIdleTimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentGuestIdleTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentGuestIdleTime_Base", value);
            }
        }

        public System.UInt64? PercentGuestRunTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentGuestRunTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentGuestRunTime", value);
            }
        }

        public System.UInt64? PercentGuestRunTimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentGuestRunTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentGuestRunTime_Base", value);
            }
        }

        public System.UInt64? PercentHypervisorRunTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentHypervisorRunTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentHypervisorRunTime", value);
            }
        }

        public System.UInt64? PercentHypervisorRunTimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentHypervisorRunTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentHypervisorRunTime_Base", value);
            }
        }

        public System.UInt64? PercentRemoteRunTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentRemoteRunTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentRemoteRunTime", value);
            }
        }

        public System.UInt64? PercentRemoteRunTimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentRemoteRunTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentRemoteRunTime_Base", value);
            }
        }

        public System.UInt64? PercentTotalCoreRunTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentTotalCoreRunTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentTotalCoreRunTime", value);
            }
        }

        public System.UInt64? PercentTotalCoreRunTimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentTotalCoreRunTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentTotalCoreRunTime_Base", value);
            }
        }

        public System.UInt64? PercentTotalRunTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentTotalRunTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentTotalRunTime", value);
            }
        }

        public System.UInt64? PercentTotalRunTimeBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentTotalRunTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentTotalRunTime_Base", value);
            }
        }

        public System.UInt64? PostedInterruptNotificationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PostedInterruptNotificationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PostedInterruptNotificationsPersec", value);
            }
        }

        public System.UInt64? PostedInterruptScansPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PostedInterruptScansPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PostedInterruptScansPersec", value);
            }
        }

        public System.UInt64? ReflectedGuestPageFaultsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReflectedGuestPageFaultsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReflectedGuestPageFaultsPersec", value);
            }
        }

        public System.UInt64? SmallPageTLBFillsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SmallPageTLBFillsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SmallPageTLBFillsPersec", value);
            }
        }

        public System.UInt64? SyntheticInterruptHypercallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SyntheticInterruptHypercallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SyntheticInterruptHypercallsPersec", value);
            }
        }

        public System.UInt64? SyntheticInterruptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SyntheticInterruptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SyntheticInterruptsPersec", value);
            }
        }

        public System.UInt64? TotalInterceptsCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInterceptsCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInterceptsCost", value);
            }
        }

        public System.UInt64? TotalInterceptsCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInterceptsCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInterceptsCost_Base", value);
            }
        }

        public System.UInt64? TotalInterceptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalInterceptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalInterceptsPersec", value);
            }
        }

        public System.UInt64? TotalMessagesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalMessagesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalMessagesPersec", value);
            }
        }

        public System.UInt64? TotalVirtualizationInstructionsEmulatedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalVirtualizationInstructionsEmulatedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalVirtualizationInstructionsEmulatedPersec", value);
            }
        }

        public System.UInt64? TotalVirtualizationInstructionsEmulationCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalVirtualizationInstructionsEmulationCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalVirtualizationInstructionsEmulationCost", value);
            }
        }

        public System.UInt64? TotalVirtualizationInstructionsEmulationCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalVirtualizationInstructionsEmulationCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalVirtualizationInstructionsEmulationCost_Base", value);
            }
        }

        public System.UInt64? VirtualInterruptHypercallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualInterruptHypercallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualInterruptHypercallsPersec", value);
            }
        }

        public System.UInt64? VirtualInterruptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualInterruptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualInterruptsPersec", value);
            }
        }

        public System.UInt64? VirtualMMUHypercallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualMMUHypercallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualMMUHypercallsPersec", value);
            }
        }

        public System.UInt64? VirtualProcessorHypercallsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualProcessorHypercallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualProcessorHypercallsPersec", value);
            }
        }

        public System.UInt64? VMCLEAREmulationInterceptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMCLEAREmulationInterceptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMCLEAREmulationInterceptsPersec", value);
            }
        }

        public System.UInt64? VMCLEARInstructionEmulationCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMCLEARInstructionEmulationCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMCLEARInstructionEmulationCost", value);
            }
        }

        public System.UInt64? VMCLEARInstructionEmulationCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMCLEARInstructionEmulationCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMCLEARInstructionEmulationCost_Base", value);
            }
        }

        public System.UInt64? VMPTRLDEmulationInterceptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMPTRLDEmulationInterceptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMPTRLDEmulationInterceptsPersec", value);
            }
        }

        public System.UInt64? VMPTRLDInstructionEmulationCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMPTRLDInstructionEmulationCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMPTRLDInstructionEmulationCost", value);
            }
        }

        public System.UInt64? VMPTRLDInstructionEmulationCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMPTRLDInstructionEmulationCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMPTRLDInstructionEmulationCost_Base", value);
            }
        }

        public System.UInt64? VMPTRSTEmulationInterceptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMPTRSTEmulationInterceptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMPTRSTEmulationInterceptsPersec", value);
            }
        }

        public System.UInt64? VMPTRSTInstructionEmulationCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMPTRSTInstructionEmulationCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMPTRSTInstructionEmulationCost", value);
            }
        }

        public System.UInt64? VMPTRSTInstructionEmulationCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMPTRSTInstructionEmulationCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMPTRSTInstructionEmulationCost_Base", value);
            }
        }

        public System.UInt64? VMREADEmulationInterceptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMREADEmulationInterceptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMREADEmulationInterceptsPersec", value);
            }
        }

        public System.UInt64? VMREADInstructionEmulationCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMREADInstructionEmulationCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMREADInstructionEmulationCost", value);
            }
        }

        public System.UInt64? VMREADInstructionEmulationCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMREADInstructionEmulationCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMREADInstructionEmulationCost_Base", value);
            }
        }

        public System.UInt64? VMWRITEEmulationInterceptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMWRITEEmulationInterceptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMWRITEEmulationInterceptsPersec", value);
            }
        }

        public System.UInt64? VMWRITEInstructionEmulationCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMWRITEInstructionEmulationCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMWRITEInstructionEmulationCost", value);
            }
        }

        public System.UInt64? VMWRITEInstructionEmulationCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMWRITEInstructionEmulationCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMWRITEInstructionEmulationCost_Base", value);
            }
        }

        public System.UInt64? VMXOFFEmulationInterceptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMXOFFEmulationInterceptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMXOFFEmulationInterceptsPersec", value);
            }
        }

        public System.UInt64? VMXOFFInstructionEmulationCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMXOFFInstructionEmulationCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMXOFFInstructionEmulationCost", value);
            }
        }

        public System.UInt64? VMXOFFInstructionEmulationCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMXOFFInstructionEmulationCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMXOFFInstructionEmulationCost_Base", value);
            }
        }

        public System.UInt64? VMXONEmulationInterceptsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMXONEmulationInterceptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMXONEmulationInterceptsPersec", value);
            }
        }

        public System.UInt64? VMXONInstructionEmulationCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMXONInstructionEmulationCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMXONInstructionEmulationCost", value);
            }
        }

        public System.UInt64? VMXONInstructionEmulationCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VMXONInstructionEmulationCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMXONInstructionEmulationCost_Base", value);
            }
        }
    }
}