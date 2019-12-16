using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetIPHttpsStateAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetIPHttpsState", "CIM_LANEndpoint", "MSFT_NetIPHttpsConfiguration", "ManagedElement", "SettingData");
        private IInfrastructureObjectScope _scope;
        public MSFTNetIPHttpsStateAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetIPHttpsConfiguration> SettingData(CIMLANEndpoint inManagedElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inManagedElement.AsCimInstance());
            return instances.Select(i => (MSFTNetIPHttpsConfiguration)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMLANEndpoint> ManagedElement(MSFTNetIPHttpsConfiguration inSettingData)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSettingData.AsCimInstance());
            return instances.Select(i => (CIMLANEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetIPHttpsConfiguration> SettingDataAsync(CIMLANEndpoint inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetIPHttpsConfiguration)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLANEndpoint> ManagedElementAsync(MSFTNetIPHttpsConfiguration inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (CIMLANEndpoint)scope.Mapper.Create(scope, i));
        }
    }
}