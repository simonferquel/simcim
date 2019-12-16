using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LogicalDisk : CIMLogicalDisk
    {
        public Win32LogicalDisk()
        {
        }

        public Win32LogicalDisk(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Compressed
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Compressed", out result);
                return result;
            }
        }

        public System.UInt32? DriveType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DriveType", out result);
                return result;
            }
        }

        public System.String FileSystem
        {
            get
            {
                System.String result;
                this.GetProperty("FileSystem", out result);
                return result;
            }
        }

        public System.UInt32? MaximumComponentLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumComponentLength", out result);
                return result;
            }
        }

        public System.UInt32? MediaType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MediaType", out result);
                return result;
            }
        }

        public System.String ProviderName
        {
            get
            {
                System.String result;
                this.GetProperty("ProviderName", out result);
                return result;
            }
        }

        public System.Boolean? QuotasDisabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("QuotasDisabled", out result);
                return result;
            }
        }

        public System.Boolean? QuotasIncomplete
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("QuotasIncomplete", out result);
                return result;
            }
        }

        public System.Boolean? QuotasRebuilding
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("QuotasRebuilding", out result);
                return result;
            }
        }

        public System.Boolean? SupportsDiskQuotas
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsDiskQuotas", out result);
                return result;
            }
        }

        public System.Boolean? SupportsFileBasedCompression
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsFileBasedCompression", out result);
                return result;
            }
        }

        public System.Boolean? VolumeDirty
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("VolumeDirty", out result);
                return result;
            }
        }

        public System.String VolumeName
        {
            get
            {
                System.String result;
                this.GetProperty("VolumeName", out result);
                return result;
            }

            set
            {
                this.SetProperty("VolumeName", value);
            }
        }

        public System.String VolumeSerialNumber
        {
            get
            {
                System.String result;
                this.GetProperty("VolumeSerialNumber", out result);
                return result;
            }
        }

        public System.UInt32 Chkdsk(System.Boolean? inFixErrors, System.Boolean? inForceDismount, System.Boolean? inOkToRunAtBootUp, System.Boolean? inRecoverBadSectors, System.Boolean? inSkipFolderCycle, System.Boolean? inVigorousIndexCheck)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFixErrors.HasValue)
                parameters.Add(CimMethodParameter.Create("FixErrors", inFixErrors.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("FixErrors", null, CimFlags.NullValue));
            if (inForceDismount.HasValue)
                parameters.Add(CimMethodParameter.Create("ForceDismount", inForceDismount.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ForceDismount", null, CimFlags.NullValue));
            if (inOkToRunAtBootUp.HasValue)
                parameters.Add(CimMethodParameter.Create("OkToRunAtBootUp", inOkToRunAtBootUp.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("OkToRunAtBootUp", null, CimFlags.NullValue));
            if (inRecoverBadSectors.HasValue)
                parameters.Add(CimMethodParameter.Create("RecoverBadSectors", inRecoverBadSectors.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("RecoverBadSectors", null, CimFlags.NullValue));
            if (inSkipFolderCycle.HasValue)
                parameters.Add(CimMethodParameter.Create("SkipFolderCycle", inSkipFolderCycle.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("SkipFolderCycle", null, CimFlags.NullValue));
            if (inVigorousIndexCheck.HasValue)
                parameters.Add(CimMethodParameter.Create("VigorousIndexCheck", inVigorousIndexCheck.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("VigorousIndexCheck", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Chkdsk", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ScheduleAutoChk(System.String[] inLogicalDisk)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("LogicalDisk", inLogicalDisk, CimType.StringArray, inLogicalDisk == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ScheduleAutoChk", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ExcludeFromAutochk(System.String[] inLogicalDisk)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("LogicalDisk", inLogicalDisk, CimType.StringArray, inLogicalDisk == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ExcludeFromAutochk", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public Win32DiskPartition ResolveWin32LogicalDiskToPartitionAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalDiskToPartition", "Win32_DiskPartition", "Dependent", "Antecedent");
            return instances.Select(i => (Win32DiskPartition)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<Win32Directory> ResolveWin32LogicalDiskRootDirectoryPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalDiskRootDirectory", "Win32_Directory", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32Directory)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public Win32QuotaSetting ResolveWin32VolumeQuotaSettingSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_VolumeQuotaSetting", "Win32_QuotaSetting", "Element", "Setting");
            return instances.Select(i => (Win32QuotaSetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32Account ResolveWin32DiskQuotaUser()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_DiskQuota", "Win32_Account", "QuotaVolume", "User");
            return instances.Select(i => (Win32Account)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}