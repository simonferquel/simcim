using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ConnectionShareAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ConnectionShare", "Win32_Share", "Win32_ServerConnection", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32ConnectionShareAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32ServerConnection> Dependent(Win32Share inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (Win32ServerConnection)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32Share> Antecedent(Win32ServerConnection inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (Win32Share)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ServerConnection> DependentAsync(Win32Share inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32ServerConnection)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Share> AntecedentAsync(Win32ServerConnection inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32Share)scope.Mapper.Create(scope, i));
        }
    }
}