using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32CheckCheckAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_CheckCheck", "CIM_Check", "CIM_Check", "Check", "Location");
        private IInfrastructureObjectScope _scope;
        public Win32CheckCheckAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMCheck> Location(CIMCheck inCheck)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCheck.AsCimInstance());
            return instances.Select(i => (CIMCheck)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMCheck> Check(CIMCheck inLocation)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inLocation.AsCimInstance());
            return instances.Select(i => (CIMCheck)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMCheck> LocationAsync(CIMCheck inCheck, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCheck.AsCimInstance(), options);
            return instances.Select(i => (CIMCheck)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMCheck> CheckAsync(CIMCheck inLocation, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inLocation.AsCimInstance(), options);
            return instances.Select(i => (CIMCheck)scope.Mapper.Create(scope, i));
        }
    }
}