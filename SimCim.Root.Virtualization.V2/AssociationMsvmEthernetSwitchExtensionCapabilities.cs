using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmEthernetSwitchExtensionCapabilitiesAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_EthernetSwitchExtensionCapabilities", "Msvm_EthernetSwitchFeatureCapabilities", "Msvm_InstalledEthernetSwitchExtension", "Capabilities", "ManagedElement");
        private IInfrastructureObjectScope _scope;
        public MsvmEthernetSwitchExtensionCapabilitiesAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmInstalledEthernetSwitchExtension> ManagedElement(MsvmEthernetSwitchFeatureCapabilities inCapabilities)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCapabilities.AsCimInstance());
            return instances.Select(i => (MsvmInstalledEthernetSwitchExtension)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmEthernetSwitchFeatureCapabilities> Capabilities(MsvmInstalledEthernetSwitchExtension inManagedElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inManagedElement.AsCimInstance());
            return instances.Select(i => (MsvmEthernetSwitchFeatureCapabilities)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmInstalledEthernetSwitchExtension> ManagedElementAsync(MsvmEthernetSwitchFeatureCapabilities inCapabilities, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCapabilities.AsCimInstance(), options);
            return instances.Select(i => (MsvmInstalledEthernetSwitchExtension)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmEthernetSwitchFeatureCapabilities> CapabilitiesAsync(MsvmInstalledEthernetSwitchExtension inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MsvmEthernetSwitchFeatureCapabilities)scope.Mapper.Create(scope, i));
        }
    }
}