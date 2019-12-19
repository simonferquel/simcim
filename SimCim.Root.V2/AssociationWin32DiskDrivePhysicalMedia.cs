using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32DiskDrivePhysicalMediaAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_DiskDrivePhysicalMedia", "Win32_PhysicalMedia", "Win32_DiskDrive", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32DiskDrivePhysicalMediaAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32DiskDrive> Dependent(Win32PhysicalMedia inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32DiskDrive)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32PhysicalMedia> Antecedent(Win32DiskDrive inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32PhysicalMedia)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32DiskDrive> DependentAsync(Win32PhysicalMedia inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32DiskDrive)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32PhysicalMedia> AntecedentAsync(Win32DiskDrive inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32PhysicalMedia)scope.Mapper.Create(scope, i));
        }
    }
}