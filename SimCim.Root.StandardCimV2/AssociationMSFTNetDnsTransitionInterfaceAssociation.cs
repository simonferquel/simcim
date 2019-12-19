using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.StandardCimV2
{
    public struct MSFTNetDnsTransitionInterfaceAssociationAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetDnsTransitionInterfaceAssociation", "CIM_NetworkPort", "MSFT_NetDnsTransitionConfiguration", "ManagedElement", "SettingData");
        private IInfrastructureObjectScope _scope;
        public MSFTNetDnsTransitionInterfaceAssociationAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetDnsTransitionConfiguration> SettingData(CIMNetworkPort inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetDnsTransitionConfiguration)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMNetworkPort> ManagedElement(MSFTNetDnsTransitionConfiguration inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (CIMNetworkPort)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetDnsTransitionConfiguration> SettingDataAsync(CIMNetworkPort inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetDnsTransitionConfiguration)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMNetworkPort> ManagedElementAsync(MSFTNetDnsTransitionConfiguration inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (CIMNetworkPort)scope.Mapper.Create(scope, i));
        }
    }
}