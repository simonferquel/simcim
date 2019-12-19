using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SoftwareFeatureCheckAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SoftwareFeatureCheck", "CIM_Check", "Win32_SoftwareFeature", "Check", "Element");
        private IInfrastructureObjectScope _scope;
        public Win32SoftwareFeatureCheckAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32SoftwareFeature> Element(CIMCheck inCheck, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCheck.AsCimInstance(), options);
            return instances.Select(i => (Win32SoftwareFeature)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMCheck> Check(Win32SoftwareFeature inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (CIMCheck)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SoftwareFeature> ElementAsync(CIMCheck inCheck, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCheck.AsCimInstance(), options);
            return instances.Select(i => (Win32SoftwareFeature)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMCheck> CheckAsync(Win32SoftwareFeature inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (CIMCheck)scope.Mapper.Create(scope, i));
        }
    }
}