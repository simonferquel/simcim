using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ProductCheckAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ProductCheck", "CIM_Check", "Win32_Product", "Check", "Product");
        private IInfrastructureObjectScope _scope;
        public Win32ProductCheckAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Product> Product(CIMCheck inCheck)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCheck.AsCimInstance());
            return instances.Select(i => (Win32Product)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMCheck> Check(Win32Product inProduct)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inProduct.AsCimInstance());
            return instances.Select(i => (CIMCheck)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Product> ProductAsync(CIMCheck inCheck, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCheck.AsCimInstance(), options);
            return instances.Select(i => (Win32Product)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMCheck> CheckAsync(Win32Product inProduct, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inProduct.AsCimInstance(), options);
            return instances.Select(i => (CIMCheck)scope.Mapper.Create(scope, i));
        }
    }
}