using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32DiskDriveToDiskPartitionAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_DiskDriveToDiskPartition", "Win32_DiskDrive", "Win32_DiskPartition", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32DiskDriveToDiskPartitionAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32DiskPartition> Dependent(Win32DiskDrive inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (Win32DiskPartition)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32DiskDrive> Antecedent(Win32DiskPartition inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (Win32DiskDrive)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32DiskPartition> DependentAsync(Win32DiskDrive inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32DiskPartition)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32DiskDrive> AntecedentAsync(Win32DiskPartition inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32DiskDrive)scope.Mapper.Create(scope, i));
        }
    }
}