using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMComputerSystem : CIMSystem
    {
        protected CIMComputerSystem()
        {
        }

        protected CIMComputerSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] Dedicated
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("Dedicated", out result);
                return result;
            }

            set
            {
                this.SetProperty("Dedicated", value);
            }
        }

        public System.String[] OtherDedicatedDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("OtherDedicatedDescriptions", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherDedicatedDescriptions", value);
            }
        }

        public System.UInt16[] PowerManagementCapabilities
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("PowerManagementCapabilities", out result);
                return result;
            }

            set
            {
                this.SetProperty("PowerManagementCapabilities", value);
            }
        }

        public System.UInt16? ResetCapability
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ResetCapability", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResetCapability", value);
            }
        }

        public System.UInt32 SetPowerState(System.UInt32? inPowerState, System.DateTime? inTime)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPowerState.HasValue)
                parameters.Add(CimMethodParameter.Create("PowerState", inPowerState.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("PowerState", null, CimFlags.NullValue));
            if (inTime.HasValue)
                parameters.Add(CimMethodParameter.Create("Time", inTime.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Time", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetPowerState", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public IEnumerable<CIMBIOSElement> ResolveCIMSystemBIOSPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_SystemBIOS", "CIM_BIOSElement", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMBIOSElement)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<MsvmBIOSElement> ResolveMsvmSystemBIOSPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SystemBIOS", "Msvm_BIOSElement", "GroupComponent", "PartComponent");
            return instances.Select(i => (MsvmBIOSElement)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public CIMVirtualSystemSettingData ResolveCIMSnapshotOfVirtualSystemDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_SnapshotOfVirtualSystem", "CIM_VirtualSystemSettingData", "Antecedent", "Dependent");
            return instances.Select(i => (CIMVirtualSystemSettingData)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<CIMVirtualSystemSettingData> ResolveMsvmSnapshotOfVirtualSystemDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SnapshotOfVirtualSystem", "CIM_VirtualSystemSettingData", "Antecedent", "Dependent");
            return instances.Select(i => (CIMVirtualSystemSettingData)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public MsvmSummaryInformationBase ResolveMsvmComputerSystemSummaryInformationDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ComputerSystemSummaryInformation", "Msvm_SummaryInformationBase", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmSummaryInformationBase)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMVirtualSystemSettingData ResolveCIMLastAppliedSnapshotAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_LastAppliedSnapshot", "CIM_VirtualSystemSettingData", "Dependent", "Antecedent");
            return instances.Select(i => (CIMVirtualSystemSettingData)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<CIMVirtualSystemSettingData> ResolveMsvmLastAppliedSnapshotAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_LastAppliedSnapshot", "CIM_VirtualSystemSettingData", "Dependent", "Antecedent");
            return instances.Select(i => (CIMVirtualSystemSettingData)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public CIMVirtualSystemSettingData ResolveCIMMostCurrentSnapshotInBranchDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_MostCurrentSnapshotInBranch", "CIM_VirtualSystemSettingData", "Antecedent", "Dependent");
            return instances.Select(i => (CIMVirtualSystemSettingData)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public MsvmVirtualSystemSettingData ResolveMsvmMostCurrentSnapshotInBranchDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_MostCurrentSnapshotInBranch", "Msvm_VirtualSystemSettingData", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmVirtualSystemSettingData)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<CIMComputerSystem> ResolveMsvmReplicaSystemDependencyDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ReplicaSystemDependency", "CIM_ComputerSystem", "Antecedent", "Dependent");
            return instances.Select(i => (CIMComputerSystem)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<CIMComputerSystem> ResolveMsvmReplicaSystemDependencyAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ReplicaSystemDependency", "CIM_ComputerSystem", "Dependent", "Antecedent");
            return instances.Select(i => (CIMComputerSystem)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<MsvmVirtualSystemExportSettingData> ResolveMsvmSystemExportSettingDataSettingData()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SystemExportSettingData", "Msvm_VirtualSystemExportSettingData", "ManagedElement", "SettingData");
            return instances.Select(i => (MsvmVirtualSystemExportSettingData)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}