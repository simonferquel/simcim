using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32LoadOrderGroupServiceDependenciesAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_LoadOrderGroupServiceDependencies", "Win32_LoadOrderGroup", "Win32_BaseService", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32LoadOrderGroupServiceDependenciesAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32BaseService> Dependent(Win32LoadOrderGroup inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32BaseService)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32LoadOrderGroup> Antecedent(Win32BaseService inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32LoadOrderGroup)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32BaseService> DependentAsync(Win32LoadOrderGroup inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32BaseService)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32LoadOrderGroup> AntecedentAsync(Win32BaseService inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32LoadOrderGroup)scope.Mapper.Create(scope, i));
        }
    }
}