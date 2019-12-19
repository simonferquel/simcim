using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmSystemExportSettingDataAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_SystemExportSettingData", "CIM_ComputerSystem", "Msvm_VirtualSystemExportSettingData", "ManagedElement", "SettingData");
        private IInfrastructureObjectScope _scope;
        public MsvmSystemExportSettingDataAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmVirtualSystemExportSettingData> SettingData(CIMComputerSystem inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualSystemExportSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMComputerSystem> ManagedElement(MsvmVirtualSystemExportSettingData inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (CIMComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmVirtualSystemExportSettingData> SettingDataAsync(CIMComputerSystem inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualSystemExportSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMComputerSystem> ManagedElementAsync(MsvmVirtualSystemExportSettingData inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (CIMComputerSystem)scope.Mapper.Create(scope, i));
        }
    }
}