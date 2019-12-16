using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ShadowOnAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ShadowOn", "Win32_Volume", "Win32_ShadowCopy", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32ShadowOnAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32ShadowCopy> Dependent(Win32Volume inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (Win32ShadowCopy)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32Volume> Antecedent(Win32ShadowCopy inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (Win32Volume)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ShadowCopy> DependentAsync(Win32Volume inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32ShadowCopy)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Volume> AntecedentAsync(Win32ShadowCopy inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32Volume)scope.Mapper.Create(scope, i));
        }
    }
}