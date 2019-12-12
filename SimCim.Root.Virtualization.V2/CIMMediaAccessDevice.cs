using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMMediaAccessDevice : CIMLogicalDevice
    {
        protected CIMMediaAccessDevice()
        {
        }

        protected CIMMediaAccessDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] Capabilities
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("Capabilities", out result);
                return result;
            }

            set
            {
                this.SetProperty("Capabilities", value);
            }
        }

        public System.String[] CapabilityDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("CapabilityDescriptions", out result);
                return result;
            }

            set
            {
                this.SetProperty("CapabilityDescriptions", value);
            }
        }

        public System.String CompressionMethod
        {
            get
            {
                System.String result;
                this.GetProperty("CompressionMethod", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompressionMethod", value);
            }
        }

        public System.UInt64? DefaultBlockSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DefaultBlockSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefaultBlockSize", value);
            }
        }

        public System.String ErrorMethodology
        {
            get
            {
                System.String result;
                this.GetProperty("ErrorMethodology", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorMethodology", value);
            }
        }

        public System.DateTime? LastCleaned
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastCleaned", out result);
                return result;
            }

            set
            {
                this.SetProperty("LastCleaned", value);
            }
        }

        public System.UInt64? LoadTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LoadTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("LoadTime", value);
            }
        }

        public System.UInt64? MaxAccessTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxAccessTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxAccessTime", value);
            }
        }

        public System.UInt64? MaxBlockSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxBlockSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxBlockSize", value);
            }
        }

        public System.UInt64? MaxMediaSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxMediaSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxMediaSize", value);
            }
        }

        public System.UInt64? MaxUnitsBeforeCleaning
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxUnitsBeforeCleaning", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxUnitsBeforeCleaning", value);
            }
        }

        public System.Boolean? MediaIsLocked
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MediaIsLocked", out result);
                return result;
            }

            set
            {
                this.SetProperty("MediaIsLocked", value);
            }
        }

        public System.UInt64? MinBlockSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MinBlockSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("MinBlockSize", value);
            }
        }

        public System.UInt64? MountCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MountCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("MountCount", value);
            }
        }

        public System.Boolean? NeedsCleaning
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NeedsCleaning", out result);
                return result;
            }

            set
            {
                this.SetProperty("NeedsCleaning", value);
            }
        }

        public System.UInt32? NumberOfMediaSupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfMediaSupported", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfMediaSupported", value);
            }
        }

        public System.UInt16? Security
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Security", out result);
                return result;
            }

            set
            {
                this.SetProperty("Security", value);
            }
        }

        public System.DateTime? TimeOfLastMount
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeOfLastMount", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimeOfLastMount", value);
            }
        }

        public System.UInt64? TotalMountTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalMountTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalMountTime", value);
            }
        }

        public System.UInt32? UncompressedDataRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UncompressedDataRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("UncompressedDataRate", value);
            }
        }

        public System.String UnitsDescription
        {
            get
            {
                System.String result;
                this.GetProperty("UnitsDescription", out result);
                return result;
            }

            set
            {
                this.SetProperty("UnitsDescription", value);
            }
        }

        public System.UInt64? UnitsUsed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("UnitsUsed", out result);
                return result;
            }

            set
            {
                this.SetProperty("UnitsUsed", value);
            }
        }

        public System.UInt64? UnloadTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("UnloadTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("UnloadTime", value);
            }
        }

        public System.UInt32 LockMedia(System.Boolean? inLock)
        {
            var parameters = new CimMethodParametersCollection();
            if (inLock.HasValue)
                parameters.Add(CimMethodParameter.Create("Lock", inLock.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Lock", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "LockMedia", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public CIMStorageExtent ResolveCIMMediaPresentDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_MediaPresent", "CIM_StorageExtent", "Antecedent", "Dependent");
            return instances.Select(i => (CIMStorageExtent)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMStorageExtent ResolveMsvmMediaPresentDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_MediaPresent", "CIM_StorageExtent", "Antecedent", "Dependent");
            return instances.Select(i => (CIMStorageExtent)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}