using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SoftwareElementCheckAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SoftwareElementCheck", "CIM_Check", "Win32_SoftwareElement", "Check", "Element");
        private IInfrastructureObjectScope _scope;
        public Win32SoftwareElementCheckAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32SoftwareElement> Element(CIMCheck inCheck)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCheck.AsCimInstance());
            return instances.Select(i => (Win32SoftwareElement)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMCheck> Check(Win32SoftwareElement inElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inElement.AsCimInstance());
            return instances.Select(i => (CIMCheck)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SoftwareElement> ElementAsync(CIMCheck inCheck, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCheck.AsCimInstance(), options);
            return instances.Select(i => (Win32SoftwareElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMCheck> CheckAsync(Win32SoftwareElement inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (CIMCheck)scope.Mapper.Create(scope, i));
        }
    }
}