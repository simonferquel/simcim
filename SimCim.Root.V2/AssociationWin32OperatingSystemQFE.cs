using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32OperatingSystemQFEAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_OperatingSystemQFE", "Win32_OperatingSystem", "Win32_QuickFixEngineering", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32OperatingSystemQFEAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32QuickFixEngineering> Dependent(Win32OperatingSystem inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (Win32QuickFixEngineering)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32OperatingSystem> Antecedent(Win32QuickFixEngineering inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (Win32OperatingSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32QuickFixEngineering> DependentAsync(Win32OperatingSystem inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32QuickFixEngineering)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32OperatingSystem> AntecedentAsync(Win32QuickFixEngineering inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32OperatingSystem)scope.Mapper.Create(scope, i));
        }
    }
}