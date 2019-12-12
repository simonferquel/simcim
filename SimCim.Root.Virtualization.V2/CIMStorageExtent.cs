using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMStorageExtent : CIMLogicalDevice
    {
        protected CIMStorageExtent()
        {
        }

        protected CIMStorageExtent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Access
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Access", out result);
                return result;
            }

            set
            {
                this.SetProperty("Access", value);
            }
        }

        public System.UInt64? BlockSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BlockSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("BlockSize", value);
            }
        }

        public System.UInt64? ConsumableBlocks
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ConsumableBlocks", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConsumableBlocks", value);
            }
        }

        public System.UInt16? DataOrganization
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DataOrganization", out result);
                return result;
            }

            set
            {
                this.SetProperty("DataOrganization", value);
            }
        }

        public System.UInt16? DataRedundancy
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DataRedundancy", out result);
                return result;
            }

            set
            {
                this.SetProperty("DataRedundancy", value);
            }
        }

        public System.Byte? DeltaReservation
        {
            get
            {
                System.Byte? result;
                this.GetProperty("DeltaReservation", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeltaReservation", value);
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

        public System.UInt16[] ExtentStatus
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("ExtentStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExtentStatus", value);
            }
        }

        public System.Boolean? IsBasedOnUnderlyingRedundancy
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsBasedOnUnderlyingRedundancy", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsBasedOnUnderlyingRedundancy", value);
            }
        }

        public System.UInt16? NameFormat
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NameFormat", out result);
                return result;
            }

            set
            {
                this.SetProperty("NameFormat", value);
            }
        }

        public System.UInt16? NameNamespace
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NameNamespace", out result);
                return result;
            }

            set
            {
                this.SetProperty("NameNamespace", value);
            }
        }

        public System.Boolean? NoSinglePointOfFailure
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NoSinglePointOfFailure", out result);
                return result;
            }

            set
            {
                this.SetProperty("NoSinglePointOfFailure", value);
            }
        }

        public System.UInt64? NumberOfBlocks
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NumberOfBlocks", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfBlocks", value);
            }
        }

        public System.String OtherNameFormat
        {
            get
            {
                System.String result;
                this.GetProperty("OtherNameFormat", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherNameFormat", value);
            }
        }

        public System.String OtherNameNamespace
        {
            get
            {
                System.String result;
                this.GetProperty("OtherNameNamespace", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherNameNamespace", value);
            }
        }

        public System.UInt16? PackageRedundancy
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PackageRedundancy", out result);
                return result;
            }

            set
            {
                this.SetProperty("PackageRedundancy", value);
            }
        }

        public System.Boolean? Primordial
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Primordial", out result);
                return result;
            }

            set
            {
                this.SetProperty("Primordial", value);
            }
        }

        public System.String Purpose
        {
            get
            {
                System.String result;
                this.GetProperty("Purpose", out result);
                return result;
            }

            set
            {
                this.SetProperty("Purpose", value);
            }
        }

        public System.Boolean? SequentialAccess
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SequentialAccess", out result);
                return result;
            }

            set
            {
                this.SetProperty("SequentialAccess", value);
            }
        }

        public CIMStorageExtent ResolveCIMBasedOnDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_BasedOn", "CIM_StorageExtent", "Antecedent", "Dependent");
            return instances.Select(i => (CIMStorageExtent)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMStorageExtent ResolveCIMBasedOnAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_BasedOn", "CIM_StorageExtent", "Dependent", "Antecedent");
            return instances.Select(i => (CIMStorageExtent)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMStorageExtent ResolveMsvmBasedOnDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_BasedOn", "CIM_StorageExtent", "Antecedent", "Dependent");
            return instances.Select(i => (CIMStorageExtent)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMStorageExtent ResolveMsvmBasedOnAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_BasedOn", "CIM_StorageExtent", "Dependent", "Antecedent");
            return instances.Select(i => (CIMStorageExtent)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMMediaAccessDevice ResolveCIMMediaPresentAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_MediaPresent", "CIM_MediaAccessDevice", "Dependent", "Antecedent");
            return instances.Select(i => (CIMMediaAccessDevice)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMMediaAccessDevice ResolveMsvmMediaPresentAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_MediaPresent", "CIM_MediaAccessDevice", "Dependent", "Antecedent");
            return instances.Select(i => (CIMMediaAccessDevice)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}