using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32AssociatedProcessorMemoryAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_AssociatedProcessorMemory", "Win32_CacheMemory", "Win32_Processor", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32AssociatedProcessorMemoryAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Processor> Dependent(Win32CacheMemory inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (Win32Processor)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32CacheMemory> Antecedent(Win32Processor inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (Win32CacheMemory)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Processor> DependentAsync(Win32CacheMemory inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32Processor)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32CacheMemory> AntecedentAsync(Win32Processor inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32CacheMemory)scope.Mapper.Create(scope, i));
        }
    }
}