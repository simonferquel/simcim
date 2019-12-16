using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetNatTransitionInterfaceAssociationAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetNatTransitionInterfaceAssociation", "CIM_NetworkPort", "MSFT_NetNatTransitionConfiguration", "ManagedElement", "SettingData");
        private IInfrastructureObjectScope _scope;
        public MSFTNetNatTransitionInterfaceAssociationAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetNatTransitionConfiguration> SettingData(CIMNetworkPort inManagedElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inManagedElement.AsCimInstance());
            return instances.Select(i => (MSFTNetNatTransitionConfiguration)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMNetworkPort> ManagedElement(MSFTNetNatTransitionConfiguration inSettingData)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSettingData.AsCimInstance());
            return instances.Select(i => (CIMNetworkPort)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetNatTransitionConfiguration> SettingDataAsync(CIMNetworkPort inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetNatTransitionConfiguration)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMNetworkPort> ManagedElementAsync(MSFTNetNatTransitionConfiguration inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (CIMNetworkPort)scope.Mapper.Create(scope, i));
        }
    }
}