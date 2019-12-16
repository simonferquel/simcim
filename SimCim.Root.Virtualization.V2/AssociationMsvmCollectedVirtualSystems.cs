using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmCollectedVirtualSystemsAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_CollectedVirtualSystems", "Msvm_VirtualSystemCollection", "Msvm_ComputerSystem", "Collection", "Member");
        private IInfrastructureObjectScope _scope;
        public MsvmCollectedVirtualSystemsAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmComputerSystem> Member(MsvmVirtualSystemCollection inCollection)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCollection.AsCimInstance());
            return instances.Select(i => (MsvmComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmVirtualSystemCollection> Collection(MsvmComputerSystem inMember)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inMember.AsCimInstance());
            return instances.Select(i => (MsvmVirtualSystemCollection)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmComputerSystem> MemberAsync(MsvmVirtualSystemCollection inCollection, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCollection.AsCimInstance(), options);
            return instances.Select(i => (MsvmComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmVirtualSystemCollection> CollectionAsync(MsvmComputerSystem inMember, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inMember.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualSystemCollection)scope.Mapper.Create(scope, i));
        }
    }
}