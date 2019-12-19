using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ShadowDiffVolumeSupportAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ShadowDiffVolumeSupport", "Win32_ShadowProvider", "Win32_Volume", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32ShadowDiffVolumeSupportAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Volume> Dependent(Win32ShadowProvider inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32Volume)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32ShadowProvider> Antecedent(Win32Volume inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32ShadowProvider)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Volume> DependentAsync(Win32ShadowProvider inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32Volume)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ShadowProvider> AntecedentAsync(Win32Volume inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32ShadowProvider)scope.Mapper.Create(scope, i));
        }
    }
}