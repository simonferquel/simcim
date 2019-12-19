using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct CIMElementSettingDataAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("CIM_ElementSettingData", "CIM_ManagedElement", "CIM_SettingData", "ManagedElement", "SettingData");
        private IInfrastructureObjectScope _scope;
        public CIMElementSettingDataAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMSettingData> SettingData(CIMManagedElement inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (CIMSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMManagedElement> ManagedElement(CIMSettingData inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSettingData.AsCimInstance(), options);
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