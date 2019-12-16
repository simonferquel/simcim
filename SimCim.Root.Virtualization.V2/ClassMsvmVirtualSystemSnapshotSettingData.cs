using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualSystemSnapshotSettingData : CIMSettingData
    {
        public MsvmVirtualSystemSnapshotSettingData()
        {
        }

        public MsvmVirtualSystemSnapshotSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? ConsistencyLevel
        {
            get
            {
                System.Byte? result;
                this.GetProperty("ConsistencyLevel", out result);
                return result;
            }
        }

        public System.Byte? GuestBackupType
        {
            get
            {
                System.Byte? result;
                this.GetProperty("GuestBackupType", out result);
                return result;
            }
        }

        public System.Boolean? IgnoreNonSnapshottableDisks
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IgnoreNonSnapshottableDisks", out result);
                return result;
            }
        }
    }
}