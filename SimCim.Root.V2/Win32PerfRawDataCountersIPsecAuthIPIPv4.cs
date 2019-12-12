using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersIPsecAuthIPIPv4 : Win32PerfRawData
    {
        public Win32PerfRawDataCountersIPsecAuthIPIPv4()
        {
        }

        public Win32PerfRawDataCountersIPsecAuthIPIPv4(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActiveExtendedModeSAs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveExtendedModeSAs", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveExtendedModeSAs", value);
            }
        }

        public System.UInt32? ActiveMainModeSAs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveMainModeSAs", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveMainModeSAs", value);
            }
        }

        public System.UInt32? ActiveQuickModeSAs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveQuickModeSAs", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveQuickModeSAs", value);
            }
        }

        public System.UInt32? ExtendedModeNegotiations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExtendedModeNegotiations", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExtendedModeNegotiations", value);
            }
        }

        public System.UInt32? ExtendedModeNegotiationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExtendedModeNegotiationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExtendedModeNegotiationsPersec", value);
            }
        }

        public System.UInt32? ExtendedModeSAsThatUsedImpersonation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExtendedModeSAsThatUsedImpersonation", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExtendedModeSAsThatUsedImpersonation", value);
            }
        }

        public System.UInt32? FailedExtendedModeNegotiations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FailedExtendedModeNegotiations", out result);
                return result;
            }

            set
            {
                this.SetProperty("FailedExtendedModeNegotiations", value);
            }
        }

        public System.UInt32? FailedExtendedModeNegotiationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FailedExtendedModeNegotiationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FailedExtendedModeNegotiationsPersec", value);
            }
        }

        public System.UInt32? FailedMainModeNegotiations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FailedMainModeNegotiations", out result);
                return result;
            }

            set
            {
                this.SetProperty("FailedMainModeNegotiations", value);
            }
        }

        public System.UInt32? FailedMainModeNegotiationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FailedMainModeNegotiationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FailedMainModeNegotiationsPersec", value);
            }
        }

        public System.UInt32? FailedQuickModeNegotiations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FailedQuickModeNegotiations", out result);
                return result;
            }

            set
            {
                this.SetProperty("FailedQuickModeNegotiations", value);
            }
        }

        public System.UInt32? FailedQuickModeNegotiationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FailedQuickModeNegotiationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FailedQuickModeNegotiationsPersec", value);
            }
        }

        public System.UInt32? MainModeNegotiationRequestsReceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MainModeNegotiationRequestsReceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("MainModeNegotiationRequestsReceived", value);
            }
        }

        public System.UInt32? MainModeNegotiationRequestsReceivedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MainModeNegotiationRequestsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MainModeNegotiationRequestsReceivedPersec", value);
            }
        }

        public System.UInt32? MainModeNegotiations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MainModeNegotiations", out result);
                return result;
            }

            set
            {
                this.SetProperty("MainModeNegotiations", value);
            }
        }

        public System.UInt32? MainModeNegotiationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MainModeNegotiationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MainModeNegotiationsPersec", value);
            }
        }

        public System.UInt32? MainModeSAsThatUsedImpersonation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MainModeSAsThatUsedImpersonation", out result);
                return result;
            }

            set
            {
                this.SetProperty("MainModeSAsThatUsedImpersonation", value);
            }
        }

        public System.UInt32? MainModeSAsThatUsedImpersonationPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MainModeSAsThatUsedImpersonationPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MainModeSAsThatUsedImpersonationPersec", value);
            }
        }

        public System.UInt32? PendingExtendedModeNegotiations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PendingExtendedModeNegotiations", out result);
                return result;
            }

            set
            {
                this.SetProperty("PendingExtendedModeNegotiations", value);
            }
        }

        public System.UInt32? PendingMainModeNegotiations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PendingMainModeNegotiations", out result);
                return result;
            }

            set
            {
                this.SetProperty("PendingMainModeNegotiations", value);
            }
        }

        public System.UInt32? PendingQuickModeNegotiations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PendingQuickModeNegotiations", out result);
                return result;
            }

            set
            {
                this.SetProperty("PendingQuickModeNegotiations", value);
            }
        }

        public System.UInt32? QuickModeNegotiations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QuickModeNegotiations", out result);
                return result;
            }

            set
            {
                this.SetProperty("QuickModeNegotiations", value);
            }
        }

        public System.UInt32? QuickModeNegotiationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QuickModeNegotiationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("QuickModeNegotiationsPersec", value);
            }
        }

        public System.UInt32? SuccessfulExtendedModeNegotiations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SuccessfulExtendedModeNegotiations", out result);
                return result;
            }

            set
            {
                this.SetProperty("SuccessfulExtendedModeNegotiations", value);
            }
        }

        public System.UInt32? SuccessfulExtendedModeNegotiationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SuccessfulExtendedModeNegotiationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SuccessfulExtendedModeNegotiationsPersec", value);
            }
        }

        public System.UInt32? SuccessfulMainModeNegotiations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SuccessfulMainModeNegotiations", out result);
                return result;
            }

            set
            {
                this.SetProperty("SuccessfulMainModeNegotiations", value);
            }
        }

        public System.UInt32? SuccessfulMainModeNegotiationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SuccessfulMainModeNegotiationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SuccessfulMainModeNegotiationsPersec", value);
            }
        }

        public System.UInt32? SuccessfulQuickModeNegotiations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SuccessfulQuickModeNegotiations", out result);
                return result;
            }

            set
            {
                this.SetProperty("SuccessfulQuickModeNegotiations", value);
            }
        }

        public System.UInt32? SuccessfulQuickModeNegotiationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SuccessfulQuickModeNegotiationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SuccessfulQuickModeNegotiationsPersec", value);
            }
        }
    }
}