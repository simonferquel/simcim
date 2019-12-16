using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32DependentServiceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_DependentService", "Win32_BaseService", "Win32_BaseService", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32DependentServiceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32BaseService> Dependent(Win32BaseService inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (Win32BaseService)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32BaseService> Antecedent(Win32BaseService inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (Win32BaseService)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32BaseService> DependentAsync(Win32BaseService inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32BaseService)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32BaseService> AntecedentAsync(Win32BaseService inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32BaseService)scope.Mapper.Create(scope, i));
        }
    }
}