using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32MemoryArrayLocationAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_MemoryArrayLocation", "Win32_PhysicalMemoryArray", "Win32_MemoryArray", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32MemoryArrayLocationAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32MemoryArray> Dependent(Win32PhysicalMemoryArray inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (Win32MemoryArray)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32PhysicalMemoryArray> Antecedent(Win32MemoryArray inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (Win32PhysicalMemoryArray)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32MemoryArray> DependentAsync(Win32PhysicalMemoryArray inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32MemoryArray)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32PhysicalMemoryArray> AntecedentAsync(Win32MemoryArray inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32PhysicalMemoryArray)scope.Mapper.Create(scope, i));
        }
    }
}