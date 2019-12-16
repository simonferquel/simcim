using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmCollectedSnapshotsAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_CollectedSnapshots", "Msvm_SnapshotCollection", "Msvm_VirtualSystemSettingData", "Collection", "Member");
        private IInfrastructureObjectScope _scope;
        public MsvmCollectedSnapshotsAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmVirtualSystemSettingData> Member(MsvmSnapshotCollection inCollection)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCollection.AsCimInstance());
            return instances.Select(i => (MsvmVirtualSystemSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmSnapshotCollection> Collection(MsvmVirtualSystemSettingData inMember)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inMember.AsCimInstance());
            return instances.Select(i => (MsvmSnapshotCollection)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmVirtualSystemSettingData> MemberAsync(MsvmSnapshotCollection inCollection, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCollection.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualSystemSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmSnapshotCollection> CollectionAsync(MsvmVirtualSystemSettingData inMember, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inMember.AsCimInstance(), options);
            return instances.Select(i => (MsvmSnapshotCollection)scope.Mapper.Create(scope, i));
        }
    }
}