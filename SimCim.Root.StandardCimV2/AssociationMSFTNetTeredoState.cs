using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetTeredoStateAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetTeredoState", "CIM_LANEndpoint", "MSFT_NetTeredoConfiguration", "ManagedElement", "SettingData");
        private IInfrastructureObjectScope _scope;
        public MSFTNetTeredoStateAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetTeredoConfiguration> SettingData(CIMLANEndpoint inManagedElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inManagedElement.AsCimInstance());
            return instances.Select(i => (MSFTNetTeredoConfiguration)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMLANEndpoint> ManagedElement(MSFTNetTeredoConfiguration inSettingData)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSettingData.AsCimInstance());
            return instances.Select(i => (CIMLANEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetTeredoConfiguration> SettingDataAsync(CIMLANEndpoint inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetTeredoConfiguration)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLANEndpoint> ManagedElementAsync(MSFTNetTeredoConfiguration inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (CIMLANEndpoint)scope.Mapper.Create(scope, i));
        }
    }
}