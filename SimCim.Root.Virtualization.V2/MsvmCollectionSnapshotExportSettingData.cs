using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmCollectionSnapshotExportSettingData : CIMSettingData
    {
        public MsvmCollectionSnapshotExportSettingData()
        {
        }

        public MsvmCollectionSnapshotExportSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? BackupIntent
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("BackupIntent", out result);
                return result;
            }

            set
            {
                this.SetProperty("BackupIntent", value);
            }
        }

        public System.Boolean? CopyVmStorage
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CopyVmStorage", out result);
                return result;
            }

            set
            {
                this.SetProperty("CopyVmStorage", value);
            }
        }

        public System.String DifferentialBackupBase
        {
            get
            {
                System.String result;
                this.GetProperty("DifferentialBackupBase", out result);
                return result;
            }

            set
            {
                this.SetProperty("DifferentialBackupBase", value);
            }
        }
    }
}