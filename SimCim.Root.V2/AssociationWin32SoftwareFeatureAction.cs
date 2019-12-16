using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SoftwareFeatureActionAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SoftwareFeatureAction", "CIM_Action", "Win32_SoftwareFeature", "Action", "Element");
        private IInfrastructureObjectScope _scope;
        public Win32SoftwareFeatureActionAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32SoftwareFeature> Element(CIMAction inAction)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAction.AsCimInstance());
            return instances.Select(i => (Win32SoftwareFeature)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMAction> Action(Win32SoftwareFeature inElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inElement.AsCimInstance());
            return instances.Select(i => (CIMAction)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SoftwareFeature> ElementAsync(CIMAction inAction, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAction.AsCimInstance(), options);
            return instances.Select(i => (Win32SoftwareFeature)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMAction> ActionAsync(Win32SoftwareFeature inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (CIMAction)scope.Mapper.Create(scope, i));
        }
    }
}