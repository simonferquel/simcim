using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SoftwareFeatureParentAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SoftwareFeatureParent", "Win32_SoftwareFeature", "Win32_SoftwareFeature", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32SoftwareFeatureParentAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32SoftwareFeature> Dependent(Win32SoftwareFeature inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (Win32SoftwareFeature)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32SoftwareFeature> Antecedent(Win32SoftwareFeature inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (Win32SoftwareFeature)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SoftwareFeature> DependentAsync(Win32SoftwareFeature inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32SoftwareFeature)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SoftwareFeature> AntecedentAsync(Win32SoftwareFeature inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32SoftwareFeature)scope.Mapper.Create(scope, i));
        }
    }
}