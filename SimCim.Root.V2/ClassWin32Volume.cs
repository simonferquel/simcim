using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Volume : CIMStorageVolume
    {
        public Win32Volume()
        {
        }

        public Win32Volume(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Automount
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Automount", out result);
                return result;
            }
        }

        public System.Boolean? BootVolume
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("BootVolume", out result);
                return result;
            }
        }

        public System.UInt64? Capacity
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Capacity", out result);
                return result;
            }
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

        public System.Boolean? DirtyBitSet
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DirtyBitSet", out result);
                return result;
            }
        }

        public System.String DriveLetter
        {
            get
            {
                System.String result;
                this.GetProperty("DriveLetter", out result);
                return result;
            }

            set
            {
                this.SetProperty("DriveLetter", value);
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

        public System.UInt64? FreeSpace
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FreeSpace", out result);
                return result;
            }
        }

        public System.Boolean? IndexingEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IndexingEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("IndexingEnabled", value);
            }
        }

        public System.String Label
        {
            get
            {
                System.String result;
                this.GetProperty("Label", out result);
                return result;
            }

            set
            {
                this.SetProperty("Label", value);
            }
        }

        public System.UInt32? MaximumFileNameLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumFileNameLength", out result);
                return result;
            }
        }

        public System.Boolean? PageFilePresent
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PageFilePresent", out result);
                return result;
            }
        }

        public System.Boolean? QuotasEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("QuotasEnabled", out result);
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

        public System.UInt32? SerialNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SerialNumber", out result);
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

        public System.Boolean? SystemVolume
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SystemVolume", out result);
                return result;
            }
        }

        public System.UInt32 Chkdsk(System.Boolean? inFixErrors, System.Boolean? inForceDismount, System.Boolean? inOkToRunAtBootUp, System.Boolean? inRecoverBadSectors, System.Boolean? inSkipFolderCycle, System.Boolean? inVigorousIndexCheck)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFixErrors.HasValue)
                parameters.Add(CimMethodParameter.Create("FixErrors", inFixErrors.Value, CimFlags.None));
            if (inForceDismount.HasValue)
                parameters.Add(CimMethodParameter.Create("ForceDismount", inForceDismount.Value, CimFlags.None));
            if (inOkToRunAtBootUp.HasValue)
                parameters.Add(CimMethodParameter.Create("OkToRunAtBootUp", inOkToRunAtBootUp.Value, CimFlags.None));
            if (inRecoverBadSectors.HasValue)
                parameters.Add(CimMethodParameter.Create("RecoverBadSectors", inRecoverBadSectors.Value, CimFlags.None));
            if (inSkipFolderCycle.HasValue)
                parameters.Add(CimMethodParameter.Create("SkipFolderCycle", inSkipFolderCycle.Value, CimFlags.None));
            if (inVigorousIndexCheck.HasValue)
                parameters.Add(CimMethodParameter.Create("VigorousIndexCheck", inVigorousIndexCheck.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Chkdsk", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ScheduleAutoChk(System.String[] inVolume)
        {
            var parameters = new CimMethodParametersCollection();
            if (inVolume != null)
                parameters.Add(CimMethodParameter.Create("Volume", inVolume, CimType.StringArray, inVolume == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ScheduleAutoChk", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ExcludeFromAutoChk(System.String[] inVolume)
        {
            var parameters = new CimMethodParametersCollection();
            if (inVolume != null)
                parameters.Add(CimMethodParameter.Create("Volume", inVolume, CimType.StringArray, inVolume == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ExcludeFromAutoChk", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Format(System.UInt32? inClusterSize, System.Boolean? inEnableCompression, System.String inFileSystem, System.String inLabel, System.Boolean? inQuickFormat, System.UInt32? inVersion)
        {
            var parameters = new CimMethodParametersCollection();
            if (inClusterSize.HasValue)
                parameters.Add(CimMethodParameter.Create("ClusterSize", inClusterSize.Value, CimFlags.None));
            if (inEnableCompression.HasValue)
                parameters.Add(CimMethodParameter.Create("EnableCompression", inEnableCompression.Value, CimFlags.None));
            if (inFileSystem != null)
                parameters.Add(CimMethodParameter.Create("FileSystem", inFileSystem, CimType.String, inFileSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inLabel != null)
                parameters.Add(CimMethodParameter.Create("Label", inLabel, CimType.String, inLabel == null ? CimFlags.NullValue : CimFlags.None));
            if (inQuickFormat.HasValue)
                parameters.Add(CimMethodParameter.Create("QuickFormat", inQuickFormat.Value, CimFlags.None));
            if (inVersion.HasValue)
                parameters.Add(CimMethodParameter.Create("Version", inVersion.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Format", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, CimInstance outDefragAnalysis) Defrag(System.Boolean? inForce)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Defrag", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CimInstance)result.OutParameters["DefragAnalysis"].Value);
        }

        public (System.UInt32 retval, CimInstance outDefragAnalysis, System.Boolean? outDefragRecommended) DefragAnalysis()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DefragAnalysis", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CimInstance)result.OutParameters["DefragAnalysis"].Value, (System.Boolean? )result.OutParameters["DefragRecommended"].Value);
        }

        public System.UInt32 AddMountPoint(System.String inDirectory)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDirectory != null)
                parameters.Add(CimMethodParameter.Create("Directory", inDirectory, CimType.String, inDirectory == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddMountPoint", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Mount()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Mount", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Dismount(System.Boolean? inForce, System.Boolean? inPermanent)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            if (inPermanent.HasValue)
                parameters.Add(CimMethodParameter.Create("Permanent", inPermanent.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Dismount", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}