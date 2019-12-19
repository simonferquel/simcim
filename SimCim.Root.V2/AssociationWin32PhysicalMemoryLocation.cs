using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32PhysicalMemoryLocationAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_PhysicalMemoryLocation", "Win32_PhysicalMemoryArray", "Win32_PhysicalMemory", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public Win32PhysicalMemoryLocationAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32PhysicalMemory> PartComponent(Win32PhysicalMemoryArray inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32PhysicalMemory)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32PhysicalMemoryArray> GroupComponent(Win32PhysicalMemory inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32PhysicalMemoryArray)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32PhysicalMemory> PartComponentAsync(Win32PhysicalMemoryArray inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32PhysicalMemory)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32PhysicalMemoryArray> GroupComponentAsync(Win32PhysicalMemory inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32PhysicalMemoryArray)scope.Mapper.Create(scope, i));
        }
    }
}