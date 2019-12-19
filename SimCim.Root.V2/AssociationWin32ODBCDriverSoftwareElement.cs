using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ODBCDriverSoftwareElementAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ODBCDriverSoftwareElement", "Win32_ODBCDriverSpecification", "Win32_SoftwareElement", "Check", "Element");
        private IInfrastructureObjectScope _scope;
        public Win32ODBCDriverSoftwareElementAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32SoftwareElement> Element(Win32ODBCDriverSpecification inCheck, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCheck.AsCimInstance(), options);
            return instances.Select(i => (Win32SoftwareElement)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32ODBCDriverSpecification> Check(Win32SoftwareElement inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32ODBCDriverSpecification)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SoftwareElement> ElementAsync(Win32ODBCDriverSpecification inCheck, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCheck.AsCimInstance(), options);
            return instances.Select(i => (Win32SoftwareElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ODBCDriverSpecification> CheckAsync(Win32SoftwareElement inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32ODBCDriverSpecification)scope.Mapper.Create(scope, i));
        }
    }
}