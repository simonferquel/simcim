using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32LogicalDiskToPartitionAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_LogicalDiskToPartition", "Win32_DiskPartition", "Win32_LogicalDisk", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32LogicalDiskToPartitionAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32LogicalDisk> Dependent(Win32DiskPartition inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32LogicalDisk)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32DiskPartition> Antecedent(Win32LogicalDisk inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32DiskPartition)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32LogicalDisk> DependentAsync(Win32DiskPartition inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32LogicalDisk)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32DiskPartition> AntecedentAsync(Win32LogicalDisk inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32DiskPartition)scope.Mapper.Create(scope, i));
        }
    }
}