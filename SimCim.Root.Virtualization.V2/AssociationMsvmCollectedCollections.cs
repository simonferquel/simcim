using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmCollectedCollectionsAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_CollectedCollections", "Msvm_ManagementCollection", "CIM_CollectionOfMSEs", "Collection", "Member");
        private IInfrastructureObjectScope _scope;
        public MsvmCollectedCollectionsAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMCollectionOfMSEs> Member(MsvmManagementCollection inCollection)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCollection.AsCimInstance());
            return instances.Select(i => (CIMCollectionOfMSEs)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmManagementCollection> Collection(CIMCollectionOfMSEs inMember)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inMember.AsCimInstance());
            return instances.Select(i => (MsvmManagementCollection)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMCollectionOfMSEs> MemberAsync(MsvmManagementCollection inCollection, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCollection.AsCimInstance(), options);
            return instances.Select(i => (CIMCollectionOfMSEs)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmManagementCollection> CollectionAsync(CIMCollectionOfMSEs inMember, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inMember.AsCimInstance(), options);
            return instances.Select(i => (MsvmManagementCollection)scope.Mapper.Create(scope, i));
        }
    }
}