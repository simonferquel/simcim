using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersStorageSpacesVirtualDisk : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersStorageSpacesVirtualDisk()
        {
        }

        public Win32PerfFormattedDataCountersStorageSpacesVirtualDisk(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? VirtualDiskActive
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskActive", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskActive", value);
            }
        }

        public System.UInt64? VirtualDiskActiveBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskActiveBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskActiveBytes", value);
            }
        }

        public System.UInt64? VirtualDiskFailedReplacementBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskFailedReplacementBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskFailedReplacementBytes", value);
            }
        }

        public System.UInt64? VirtualDiskFailedReplacementCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskFailedReplacementCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskFailedReplacementCount", value);
            }
        }

        public System.UInt64? VirtualDiskMissing
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskMissing", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskMissing", value);
            }
        }

        public System.UInt64? VirtualDiskMissingBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskMissingBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskMissingBytes", value);
            }
        }

        public System.UInt64? VirtualDiskNeedReallocation
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskNeedReallocation", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskNeedReallocation", value);
            }
        }

        public System.UInt64? VirtualDiskNeedReallocationBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskNeedReallocationBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskNeedReallocationBytes", value);
            }
        }

        public System.UInt64? VirtualDiskNeedRegeneration
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskNeedRegeneration", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskNeedRegeneration", value);
            }
        }

        public System.UInt64? VirtualDiskNeedRegenerationBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskNeedRegenerationBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskNeedRegenerationBytes", value);
            }
        }

        public System.UInt64? VirtualDiskPendingDeletion
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskPendingDeletion", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskPendingDeletion", value);
            }
        }

        public System.UInt64? VirtualDiskPendingDeletionBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskPendingDeletionBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskPendingDeletionBytes", value);
            }
        }

        public System.UInt64? VirtualDiskReasonFailure
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskReasonFailure", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskReasonFailure", value);
            }
        }

        public System.UInt64? VirtualDiskReasonFailureBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskReasonFailureBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskReasonFailureBytes", value);
            }
        }

        public System.UInt64? VirtualDiskReasonHardwareError
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskReasonHardwareError", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskReasonHardwareError", value);
            }
        }

        public System.UInt64? VirtualDiskReasonHardwareErrorBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskReasonHardwareErrorBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskReasonHardwareErrorBytes", value);
            }
        }

        public System.UInt64? VirtualDiskReasonIoError
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskReasonIoError", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskReasonIoError", value);
            }
        }

        public System.UInt64? VirtualDiskReasonIoErrorBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskReasonIoErrorBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskReasonIoErrorBytes", value);
            }
        }

        public System.UInt64? VirtualDiskReasonMissing
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskReasonMissing", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskReasonMissing", value);
            }
        }

        public System.UInt64? VirtualDiskReasonMissingBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskReasonMissingBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskReasonMissingBytes", value);
            }
        }

        public System.UInt64? VirtualDiskReasonNew
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskReasonNew", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskReasonNew", value);
            }
        }

        public System.UInt64? VirtualDiskReasonNewBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskReasonNewBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskReasonNewBytes", value);
            }
        }

        public System.UInt64? VirtualDiskReasonRegenReadError
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskReasonRegenReadError", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskReasonRegenReadError", value);
            }
        }

        public System.UInt64? VirtualDiskReasonRegenReadErrorBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskReasonRegenReadErrorBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskReasonRegenReadErrorBytes", value);
            }
        }

        public System.UInt64? VirtualDiskReasonRegenWriteError
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskReasonRegenWriteError", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskReasonRegenWriteError", value);
            }
        }

        public System.UInt64? VirtualDiskReasonRegenWriteErrorBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskReasonRegenWriteErrorBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskReasonRegenWriteErrorBytes", value);
            }
        }

        public System.UInt64? VirtualDiskReasonRetired
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskReasonRetired", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskReasonRetired", value);
            }
        }

        public System.UInt64? VirtualDiskReasonRetiredBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskReasonRetiredBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskReasonRetiredBytes", value);
            }
        }

        public System.UInt64? VirtualDiskRebalanceReplacementBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRebalanceReplacementBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRebalanceReplacementBytes", value);
            }
        }

        public System.UInt64? VirtualDiskRebalanceReplacementCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRebalanceReplacementCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRebalanceReplacementCount", value);
            }
        }

        public System.UInt64? VirtualDiskRegenerating
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRegenerating", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRegenerating", value);
            }
        }

        public System.UInt64? VirtualDiskRegeneratingBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRegeneratingBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRegeneratingBytes", value);
            }
        }

        public System.UInt64? VirtualDiskRegenerationOutstandingBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRegenerationOutstandingBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRegenerationOutstandingBytes", value);
            }
        }

        public System.UInt64? VirtualDiskRegenerationProcessedBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRegenerationProcessedBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRegenerationProcessedBytes", value);
            }
        }

        public System.UInt64? VirtualDiskRegenerationSkippedBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRegenerationSkippedBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRegenerationSkippedBytes", value);
            }
        }

        public System.UInt64? VirtualDiskRegenerationTotalBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRegenerationTotalBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRegenerationTotalBytes", value);
            }
        }

        public System.UInt64? VirtualDiskRepairNeedPhase2Count
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRepairNeedPhase2Count", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRepairNeedPhase2Count", value);
            }
        }

        public System.UInt64? VirtualDiskRepairNeedPhase6Count
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRepairNeedPhase6Count", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRepairNeedPhase6Count", value);
            }
        }

        public System.UInt64? VirtualDiskRepairPhase1Count
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRepairPhase1Count", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRepairPhase1Count", value);
            }
        }

        public System.UInt64? VirtualDiskRepairPhase1Status
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRepairPhase1Status", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRepairPhase1Status", value);
            }
        }

        public System.UInt64? VirtualDiskRepairPhase2Count
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRepairPhase2Count", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRepairPhase2Count", value);
            }
        }

        public System.UInt64? VirtualDiskRepairPhase2Status
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRepairPhase2Status", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRepairPhase2Status", value);
            }
        }

        public System.UInt64? VirtualDiskRepairPhase3Count
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRepairPhase3Count", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRepairPhase3Count", value);
            }
        }

        public System.UInt64? VirtualDiskRepairPhase3Status
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRepairPhase3Status", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRepairPhase3Status", value);
            }
        }

        public System.UInt64? VirtualDiskRepairPhase4Count
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRepairPhase4Count", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRepairPhase4Count", value);
            }
        }

        public System.UInt64? VirtualDiskRepairPhase4Status
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRepairPhase4Status", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRepairPhase4Status", value);
            }
        }

        public System.UInt64? VirtualDiskRepairPhase5Count
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRepairPhase5Count", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRepairPhase5Count", value);
            }
        }

        public System.UInt64? VirtualDiskRepairPhase5Status
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRepairPhase5Status", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRepairPhase5Status", value);
            }
        }

        public System.UInt64? VirtualDiskRepairPhase6Count
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRepairPhase6Count", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRepairPhase6Count", value);
            }
        }

        public System.UInt64? VirtualDiskRepairPhase6Status
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRepairPhase6Status", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRepairPhase6Status", value);
            }
        }

        public System.UInt64? VirtualDiskRepairReplacementBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRepairReplacementBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRepairReplacementBytes", value);
            }
        }

        public System.UInt64? VirtualDiskRepairReplacementCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskRepairReplacementCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskRepairReplacementCount", value);
            }
        }

        public System.UInt64? VirtualDiskScopeRegenerationBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskScopeRegenerationBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskScopeRegenerationBytes", value);
            }
        }

        public System.UInt64? VirtualDiskScopeRegenerationCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskScopeRegenerationCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskScopeRegenerationCount", value);
            }
        }

        public System.UInt64? VirtualDiskStale
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskStale", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskStale", value);
            }
        }

        public System.UInt64? VirtualDiskStaleBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskStaleBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskStaleBytes", value);
            }
        }

        public System.UInt64? VirtualDiskTotal
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskTotal", value);
            }
        }

        public System.UInt64? VirtualDiskTotalBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualDiskTotalBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskTotalBytes", value);
            }
        }
    }
}