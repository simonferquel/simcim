using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualSystemExportSettingData : CIMSettingData
    {
        public MsvmVirtualSystemExportSettingData()
        {
        }

        public MsvmVirtualSystemExportSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? BackupIntent
        {
            get
            {
                System.Byte? result;
                this.GetProperty("BackupIntent", out result);
                return result;
            }

            set
            {
                this.SetProperty("BackupIntent", value);
            }
        }

        public System.Byte? CaptureLiveState
        {
            get
            {
                System.Byte? result;
                this.GetProperty("CaptureLiveState", out result);
                return result;
            }

            set
            {
                this.SetProperty("CaptureLiveState", value);
            }
        }

        public System.Byte? CopySnapshotConfiguration
        {
            get
            {
                System.Byte? result;
                this.GetProperty("CopySnapshotConfiguration", out result);
                return result;
            }

            set
            {
                this.SetProperty("CopySnapshotConfiguration", value);
            }
        }

        public System.Boolean? CopyVmRuntimeInformation
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CopyVmRuntimeInformation", out result);
                return result;
            }

            set
            {
                this.SetProperty("CopyVmRuntimeInformation", value);
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

        public System.Boolean? CreateVmExportSubdirectory
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CreateVmExportSubdirectory", out result);
                return result;
            }

            set
            {
                this.SetProperty("CreateVmExportSubdirectory", value);
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

        public System.Boolean? DisableDifferentialOfIgnoredStorage
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DisableDifferentialOfIgnoredStorage", out result);
                return result;
            }

            set
            {
                this.SetProperty("DisableDifferentialOfIgnoredStorage", value);
            }
        }

        public System.String[] ExcludedVirtualHardDisks
        {
            get
            {
                System.String[] result;
                this.GetProperty("ExcludedVirtualHardDisks", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExcludedVirtualHardDisks", value);
            }
        }

        public System.Boolean? ExportForLiveMigration
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ExportForLiveMigration", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExportForLiveMigration", value);
            }
        }

        public System.String SnapshotVirtualSystem
        {
            get
            {
                System.String result;
                this.GetProperty("SnapshotVirtualSystem", out result);
                return result;
            }

            set
            {
                this.SetProperty("SnapshotVirtualSystem", value);
            }
        }

        public IEnumerable<CIMComputerSystem> ResolveMsvmSystemExportSettingDataManagedElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SystemExportSettingData", "CIM_ComputerSystem", "SettingData", "ManagedElement");
            return instances.Select(i => (CIMComputerSystem)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}