using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32PNPAllocatedResourceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_PNPAllocatedResource", "CIM_SystemResource", "Win32_PNPEntity", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32PNPAllocatedResourceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CimInstance> Dependent(CIMSystemResource inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances;
        }

        public IEnumerable<CIMSystemResource> Antecedent(CimInstance inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent);
            return instances.Select(i => (CIMSystemResource)scope.Mapper.Create(scope, i));
        }

        public IObservable<CimInstance> DependentAsync(CIMSystemResource inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances;
        }

        public IObservable<CIMSystemResource> AntecedentAsync(CimInstance inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent, options);
            return instances.Select(i => (CIMSystemResource)scope.Mapper.Create(scope, i));
        }
    }
}