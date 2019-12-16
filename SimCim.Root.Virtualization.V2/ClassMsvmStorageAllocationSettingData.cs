using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmStorageAllocationSettingData : CIMStorageAllocationSettingData
    {
        public MsvmStorageAllocationSettingData()
        {
        }

        public MsvmStorageAllocationSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? CachingMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CachingMode", out result);
                return result;
            }
        }

        public System.Boolean? IgnoreFlushes
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IgnoreFlushes", out result);
                return result;
            }
        }

        public System.String IOPSAllocationUnits
        {
            get
            {
                System.String result;
                this.GetProperty("IOPSAllocationUnits", out result);
                return result;
            }
        }

        public System.UInt64? IOPSLimit
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOPSLimit", out result);
                return result;
            }
        }

        public System.UInt64? IOPSReservation
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOPSReservation", out result);
                return result;
            }
        }

        public System.Boolean? PersistentReservationsSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PersistentReservationsSupported", out result);
                return result;
            }
        }

        public System.String SnapshotId
        {
            get
            {
                System.String result;
                this.GetProperty("SnapshotId", out result);
                return result;
            }
        }

        public System.String StorageQoSPolicyID
        {
            get
            {
                System.String result;
                this.GetProperty("StorageQoSPolicyID", out result);
                return result;
            }
        }

        public System.UInt16? WriteHardeningMethod
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("WriteHardeningMethod", out result);
                return result;
            }
        }
    }
}