using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersSynchronization : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersSynchronization()
        {
        }

        public Win32PerfFormattedDataCountersSynchronization(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ExecResourceAcquiresAcqExclLitePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceAcquiresAcqExclLitePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceAcquiresAcqExclLitePersec", value);
            }
        }

        public System.UInt32? ExecResourceAcquiresAcqShrdLitePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceAcquiresAcqShrdLitePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceAcquiresAcqShrdLitePersec", value);
            }
        }

        public System.UInt32? ExecResourceAcquiresAcqShrdStarveExclPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceAcquiresAcqShrdStarveExclPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceAcquiresAcqShrdStarveExclPersec", value);
            }
        }

        public System.UInt32? ExecResourceAcquiresAcqShrdWaitForExclPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceAcquiresAcqShrdWaitForExclPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceAcquiresAcqShrdWaitForExclPersec", value);
            }
        }

        public System.UInt32? ExecResourceAttemptsAcqExclLitePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceAttemptsAcqExclLitePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceAttemptsAcqExclLitePersec", value);
            }
        }

        public System.UInt32? ExecResourceAttemptsAcqShrdLitePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceAttemptsAcqShrdLitePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceAttemptsAcqShrdLitePersec", value);
            }
        }

        public System.UInt32? ExecResourceAttemptsAcqShrdStarveExclPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceAttemptsAcqShrdStarveExclPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceAttemptsAcqShrdStarveExclPersec", value);
            }
        }

        public System.UInt32? ExecResourceAttemptsAcqShrdWaitForExclPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceAttemptsAcqShrdWaitForExclPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceAttemptsAcqShrdWaitForExclPersec", value);
            }
        }

        public System.UInt32? ExecResourceBoostExclOwnerPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceBoostExclOwnerPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceBoostExclOwnerPersec", value);
            }
        }

        public System.UInt32? ExecResourceBoostSharedOwnersPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceBoostSharedOwnersPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceBoostSharedOwnersPersec", value);
            }
        }

        public System.UInt32? ExecResourceContentionAcqExclLitePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceContentionAcqExclLitePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceContentionAcqExclLitePersec", value);
            }
        }

        public System.UInt32? ExecResourceContentionAcqShrdLitePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceContentionAcqShrdLitePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceContentionAcqShrdLitePersec", value);
            }
        }

        public System.UInt32? ExecResourceContentionAcqShrdStarveExclPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceContentionAcqShrdStarveExclPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceContentionAcqShrdStarveExclPersec", value);
            }
        }

        public System.UInt32? ExecResourceContentionAcqShrdWaitForExclPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceContentionAcqShrdWaitForExclPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceContentionAcqShrdWaitForExclPersec", value);
            }
        }

        public System.UInt32? ExecResourcenoWaitsAcqExclLitePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourcenoWaitsAcqExclLitePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourcenoWaitsAcqExclLitePersec", value);
            }
        }

        public System.UInt32? ExecResourcenoWaitsAcqShrdLitePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourcenoWaitsAcqShrdLitePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourcenoWaitsAcqShrdLitePersec", value);
            }
        }

        public System.UInt32? ExecResourcenoWaitsAcqShrdStarveExclPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourcenoWaitsAcqShrdStarveExclPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourcenoWaitsAcqShrdStarveExclPersec", value);
            }
        }

        public System.UInt32? ExecResourcenoWaitsAcqShrdWaitForExclPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourcenoWaitsAcqShrdWaitForExclPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourcenoWaitsAcqShrdWaitForExclPersec", value);
            }
        }

        public System.UInt32? ExecResourceRecursiveExclAcquiresAcqExclLitePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceRecursiveExclAcquiresAcqExclLitePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceRecursiveExclAcquiresAcqExclLitePersec", value);
            }
        }

        public System.UInt32? ExecResourceRecursiveExclAcquiresAcqShrdLitePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceRecursiveExclAcquiresAcqShrdLitePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceRecursiveExclAcquiresAcqShrdLitePersec", value);
            }
        }

        public System.UInt32? ExecResourceRecursiveExclAcquiresAcqShrdStarveExclPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceRecursiveExclAcquiresAcqShrdStarveExclPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceRecursiveExclAcquiresAcqShrdStarveExclPersec", value);
            }
        }

        public System.UInt32? ExecResourceRecursiveExclAcquiresAcqShrdWaitForExclPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceRecursiveExclAcquiresAcqShrdWaitForExclPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceRecursiveExclAcquiresAcqShrdWaitForExclPersec", value);
            }
        }

        public System.UInt32? ExecResourceRecursiveShAcquiresAcqShrdLitePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceRecursiveShAcquiresAcqShrdLitePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceRecursiveShAcquiresAcqShrdLitePersec", value);
            }
        }

        public System.UInt32? ExecResourceRecursiveShAcquiresAcqShrdStarveExclPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceRecursiveShAcquiresAcqShrdStarveExclPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceRecursiveShAcquiresAcqShrdStarveExclPersec", value);
            }
        }

        public System.UInt32? ExecResourceRecursiveShAcquiresAcqShrdWaitForExclPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceRecursiveShAcquiresAcqShrdWaitForExclPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceRecursiveShAcquiresAcqShrdWaitForExclPersec", value);
            }
        }

        public System.UInt32? ExecResourceSetOwnerPointerExclusivePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceSetOwnerPointerExclusivePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceSetOwnerPointerExclusivePersec", value);
            }
        }

        public System.UInt32? ExecResourceSetOwnerPointerSharedExistingOwnerPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceSetOwnerPointerSharedExistingOwnerPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceSetOwnerPointerSharedExistingOwnerPersec", value);
            }
        }

        public System.UInt32? ExecResourceSetOwnerPointerSharedNewOwnerPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceSetOwnerPointerSharedNewOwnerPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceSetOwnerPointerSharedNewOwnerPersec", value);
            }
        }

        public System.UInt32? ExecResourceTotalAcquiresPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceTotalAcquiresPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceTotalAcquiresPersec", value);
            }
        }

        public System.UInt32? ExecResourceTotalContentionsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceTotalContentionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceTotalContentionsPersec", value);
            }
        }

        public System.UInt32? ExecResourceTotalConvExclusiveToSharedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceTotalConvExclusiveToSharedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceTotalConvExclusiveToSharedPersec", value);
            }
        }

        public System.UInt32? ExecResourceTotalDeletePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceTotalDeletePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceTotalDeletePersec", value);
            }
        }

        public System.UInt32? ExecResourceTotalExclusiveReleasesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceTotalExclusiveReleasesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceTotalExclusiveReleasesPersec", value);
            }
        }

        public System.UInt32? ExecResourceTotalInitializePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceTotalInitializePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceTotalInitializePersec", value);
            }
        }

        public System.UInt32? ExecResourceTotalReInitializePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceTotalReInitializePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceTotalReInitializePersec", value);
            }
        }

        public System.UInt32? ExecResourceTotalSharedReleasesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExecResourceTotalSharedReleasesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecResourceTotalSharedReleasesPersec", value);
            }
        }

        public System.UInt32? IPISendBroadcastRequestsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPISendBroadcastRequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPISendBroadcastRequestsPersec", value);
            }
        }

        public System.UInt32? IPISendRoutineRequestsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPISendRoutineRequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPISendRoutineRequestsPersec", value);
            }
        }

        public System.UInt32? IPISendSoftwareInterruptsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPISendSoftwareInterruptsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPISendSoftwareInterruptsPersec", value);
            }
        }

        public System.UInt32? SpinlockAcquiresPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SpinlockAcquiresPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SpinlockAcquiresPersec", value);
            }
        }

        public System.UInt32? SpinlockContentionsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SpinlockContentionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SpinlockContentionsPersec", value);
            }
        }

        public System.UInt32? SpinlockSpinsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SpinlockSpinsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SpinlockSpinsPersec", value);
            }
        }
    }
}