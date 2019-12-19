using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ProductSoftwareFeaturesAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ProductSoftwareFeatures", "Win32_SoftwareFeature", "Win32_Product", "Component", "Product");
        private IInfrastructureObjectScope _scope;
        public Win32ProductSoftwareFeaturesAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Product> Product(Win32SoftwareFeature inComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32Product)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32SoftwareFeature> Component(Win32Product inProduct, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inProduct.AsCimInstance(), options);
            return instances.Select(i => (Win32SoftwareFeature)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Product> ProductAsync(Win32SoftwareFeature inComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32Product)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SoftwareFeature> ComponentAsync(Win32Product inProduct, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inProduct.AsCimInstance(), options);
            return instances.Select(i => (Win32SoftwareFeature)scope.Mapper.Create(scope, i));
        }
    }
}