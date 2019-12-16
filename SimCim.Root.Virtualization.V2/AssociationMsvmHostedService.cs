using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmHostedServiceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_HostedService", "CIM_System", "CIM_Service", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmHostedServiceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMService> Dependent(CIMSystem inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (CIMService)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMSystem> Antecedent(CIMService inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (CIMSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMService> DependentAsync(CIMSystem inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMService)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMSystem> AntecedentAsync(CIMService inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMSystem)scope.Mapper.Create(scope, i));
        }
    }
}