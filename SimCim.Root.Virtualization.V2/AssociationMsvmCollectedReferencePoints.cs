using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmCollectedReferencePointsAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_CollectedReferencePoints", "Msvm_ReferencePointCollection", "Msvm_VirtualSystemReferencePoint", "Collection", "Member");
        private IInfrastructureObjectScope _scope;
        public MsvmCollectedReferencePointsAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmVirtualSystemReferencePoint> Member(MsvmReferencePointCollection inCollection, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCollection.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualSystemReferencePoint)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmReferencePointCollection> Collection(MsvmVirtualSystemReferencePoint inMember, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inMember.AsCimInstance(), options);
            return instances.Select(i => (MsvmReferencePointCollection)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmVirtualSystemReferencePoint> MemberAsync(MsvmReferencePointCollection inCollection, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCollection.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualSystemReferencePoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmReferencePointCollection> CollectionAsync(MsvmVirtualSystemReferencePoint inMember, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inMember.AsCimInstance(), options);
            return instances.Select(i => (MsvmReferencePointCollection)scope.Mapper.Create(scope, i));
        }
    }
}