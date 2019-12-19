using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ServiceSpecificationServiceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ServiceSpecificationService", "Win32_ServiceSpecification", "Win32_Service", "Check", "Element");
        private IInfrastructureObjectScope _scope;
        public Win32ServiceSpecificationServiceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Service> Element(Win32ServiceSpecification inCheck, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCheck.AsCimInstance(), options);
            return instances.Select(i => (Win32Service)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32ServiceSpecification> Check(Win32Service inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32ServiceSpecification)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Service> ElementAsync(Win32ServiceSpecification inCheck, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCheck.AsCimInstance(), options);
            return instances.Select(i => (Win32Service)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ServiceSpecification> CheckAsync(Win32Service inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32ServiceSpecification)scope.Mapper.Create(scope, i));
        }
    }
}