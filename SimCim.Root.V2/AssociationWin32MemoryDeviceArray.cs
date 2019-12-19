using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32MemoryDeviceArrayAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_MemoryDeviceArray", "Win32_MemoryArray", "Win32_MemoryDevice", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public Win32MemoryDeviceArrayAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32MemoryDevice> PartComponent(Win32MemoryArray inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32MemoryDevice)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32MemoryArray> GroupComponent(Win32MemoryDevice inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32MemoryArray)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32MemoryDevice> PartComponentAsync(Win32MemoryArray inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32MemoryDevice)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32MemoryArray> GroupComponentAsync(Win32MemoryDevice inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32MemoryArray)scope.Mapper.Create(scope, i));
        }
    }
}