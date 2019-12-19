using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNet6to4StateAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_Net6to4State", "CIM_LANEndpoint", "MSFT_Net6to4Configuration", "ManagedElement", "SettingData");
        private IInfrastructureObjectScope _scope;
        public MSFTNet6to4StateAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNet6to4Configuration> SettingData(CIMLANEndpoint inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MSFTNet6to4Configuration)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMLANEndpoint> ManagedElement(MSFTNet6to4Configuration inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (CIMLANEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNet6to4Configuration> SettingDataAsync(CIMLANEndpoint inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MSFTNet6to4Configuration)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLANEndpoint> ManagedElementAsync(MSFTNet6to4Configuration inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (CIMLANEndpoint)scope.Mapper.Create(scope, i));
        }
    }
}