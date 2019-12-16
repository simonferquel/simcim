using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ActionCheckAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ActionCheck", "CIM_Action", "CIM_Check", "Action", "Check");
        private IInfrastructureObjectScope _scope;
        public Win32ActionCheckAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMCheck> Check(CIMAction inAction)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAction.AsCimInstance());
            return instances.Select(i => (CIMCheck)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMAction> Action(CIMCheck inCheck)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inCheck.AsCimInstance());
            return instances.Select(i => (CIMAction)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMCheck> CheckAsync(CIMAction inAction, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAction.AsCimInstance(), options);
            return instances.Select(i => (CIMCheck)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMAction> ActionAsync(CIMCheck inCheck, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inCheck.AsCimInstance(), options);
            return instances.Select(i => (CIMAction)scope.Mapper.Create(scope, i));
        }
    }
}