using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32LoggedOnUserAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_LoggedOnUser", "Win32_Account", "Win32_LogonSession", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32LoggedOnUserAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32LogonSession> Dependent(Win32Account inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (Win32LogonSession)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32Account> Antecedent(Win32LogonSession inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (Win32Account)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32LogonSession> DependentAsync(Win32Account inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32LogonSession)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Account> AntecedentAsync(Win32LogonSession inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32Account)scope.Mapper.Create(scope, i));
        }
    }
}