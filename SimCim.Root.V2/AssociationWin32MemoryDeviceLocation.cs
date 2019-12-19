using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32MemoryDeviceLocationAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_MemoryDeviceLocation", "Win32_PhysicalMemory", "Win32_MemoryDevice", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32MemoryDeviceLocationAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32MemoryDevice> Dependent(Win32PhysicalMemory inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32MemoryDevice)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32PhysicalMemory> Antecedent(Win32MemoryDevice inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32PhysicalMemory)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32MemoryDevice> DependentAsync(Win32PhysicalMemory inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32MemoryDevice)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32PhysicalMemory> AntecedentAsync(Win32MemoryDevice inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32PhysicalMemory)scope.Mapper.Create(scope, i));
        }
    }
}