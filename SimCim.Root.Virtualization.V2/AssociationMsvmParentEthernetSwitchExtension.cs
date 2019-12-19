using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmParentEthernetSwitchExtensionAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_ParentEthernetSwitchExtension", "Msvm_EthernetSwitchExtension", "Msvm_EthernetSwitchExtension", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmParentEthernetSwitchExtensionAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmEthernetSwitchExtension> Dependent(MsvmEthernetSwitchExtension inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmEthernetSwitchExtension)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmEthernetSwitchExtension> Antecedent(MsvmEthernetSwitchExtension inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmEthernetSwitchExtension)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmEthernetSwitchExtension> DependentAsync(MsvmEthernetSwitchExtension inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmEthernetSwitchExtension)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmEthernetSwitchExtension> AntecedentAsync(MsvmEthernetSwitchExtension inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmEthernetSwitchExtension)scope.Mapper.Create(scope, i));
        }
    }
}