using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ApplicationCommandLineAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ApplicationCommandLine", "Win32_ApplicationService", "Win32_CommandLineAccess", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32ApplicationCommandLineAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32CommandLineAccess> Dependent(Win32ApplicationService inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (Win32CommandLineAccess)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32ApplicationService> Antecedent(Win32CommandLineAccess inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (Win32ApplicationService)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32CommandLineAccess> DependentAsync(Win32ApplicationService inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32CommandLineAccess)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ApplicationService> AntecedentAsync(Win32CommandLineAccess inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32ApplicationService)scope.Mapper.Create(scope, i));
        }
    }
}