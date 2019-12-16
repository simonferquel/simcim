using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmElementSettingDataAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_ElementSettingData", "CIM_ManagedElement", "CIM_SettingData", "ManagedElement", "SettingData");
        private IInfrastructureObjectScope _scope;
        public MsvmElementSettingDataAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMSettingData> SettingData(CIMManagedElement inManagedElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inManagedElement.AsCimInstance());
            return instances.Select(i => (CIMSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMManagedElement> ManagedElement(CIMSettingData inSettingData)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSettingData.AsCimInstance());
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMSettingData> SettingDataAsync(CIMManagedElement inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (CIMSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMManagedElement> ManagedElementAsync(CIMSettingData inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }
    }
}