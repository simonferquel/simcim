using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmConcreteDependencyAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_ConcreteDependency", "Msvm_InstalledEthernetSwitchExtension", "Msvm_EthernetSwitchExtension", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmConcreteDependencyAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmEthernetSwitchExtension> Dependent(MsvmInstalledEthernetSwitchExtension inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmEthernetSwitchExtension)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmInstalledEthernetSwitchExtension> Antecedent(MsvmEthernetSwitchExtension inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmInstalledEthernetSwitchExtension)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmEthernetSwitchExtension> DependentAsync(MsvmInstalledEthernetSwitchExtension inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmEthernetSwitchExtension)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmInstalledEthernetSwitchExtension> AntecedentAsync(MsvmEthernetSwitchExtension inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmInstalledEthernetSwitchExtension)scope.Mapper.Create(scope, i));
        }
    }
}