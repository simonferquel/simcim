using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ProductResourceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ProductResource", "Win32_Product", "Win32_MSIResource", "Product", "Resource");
        private IInfrastructureObjectScope _scope;
        public Win32ProductResourceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32MSIResource> Resource(Win32Product inProduct)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inProduct.AsCimInstance());
            return instances.Select(i => (Win32MSIResource)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32Product> Product(Win32MSIResource inResource)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inResource.AsCimInstance());
            return instances.Select(i => (Win32Product)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32MSIResource> ResourceAsync(Win32Product inProduct, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inProduct.AsCimInstance(), options);
            return instances.Select(i => (Win32MSIResource)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Product> ProductAsync(Win32MSIResource inResource, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inResource.AsCimInstance(), options);
            return instances.Select(i => (Win32Product)scope.Mapper.Create(scope, i));
        }
    }
}