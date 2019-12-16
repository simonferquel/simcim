using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmRegisteredGuestServiceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_RegisteredGuestService", "Msvm_GuestServiceInterfaceComponent", "Msvm_GuestService", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmRegisteredGuestServiceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmGuestService> Dependent(MsvmGuestServiceInterfaceComponent inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (MsvmGuestService)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmGuestServiceInterfaceComponent> Antecedent(MsvmGuestService inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (MsvmGuestServiceInterfaceComponent)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmGuestService> DependentAsync(MsvmGuestServiceInterfaceComponent inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmGuestService)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmGuestServiceInterfaceComponent> AntecedentAsync(MsvmGuestService inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmGuestServiceInterfaceComponent)scope.Mapper.Create(scope, i));
        }
    }
}