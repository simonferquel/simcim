using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SoftwareFeatureSoftwareElementsAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SoftwareFeatureSoftwareElements", "Win32_SoftwareFeature", "Win32_SoftwareElement", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public Win32SoftwareFeatureSoftwareElementsAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32SoftwareElement> PartComponent(Win32SoftwareFeature inGroupComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance());
            return instances.Select(i => (Win32SoftwareElement)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32SoftwareFeature> GroupComponent(Win32SoftwareElement inPartComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance());
            return instances.Select(i => (Win32SoftwareFeature)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SoftwareElement> PartComponentAsync(Win32SoftwareFeature inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32SoftwareElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SoftwareFeature> GroupComponentAsync(Win32SoftwareElement inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32SoftwareFeature)scope.Mapper.Create(scope, i));
        }
    }
}