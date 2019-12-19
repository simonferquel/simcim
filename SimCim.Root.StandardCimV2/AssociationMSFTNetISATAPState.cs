using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetISATAPStateAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetISATAPState", "CIM_LANEndpoint", "MSFT_NetISATAPConfiguration", "ManagedElement", "SettingData");
        private IInfrastructureObjectScope _scope;
        public MSFTNetISATAPStateAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetISATAPConfiguration> SettingData(CIMLANEndpoint inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetISATAPConfiguration)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMLANEndpoint> ManagedElement(MSFTNetISATAPConfiguration inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (CIMLANEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetISATAPConfiguration> SettingDataAsync(CIMLANEndpoint inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetISATAPConfiguration)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLANEndpoint> ManagedElementAsync(MSFTNetISATAPConfiguration inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (CIMLANEndpoint)scope.Mapper.Create(scope, i));
        }
    }
}