using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmServiceOfVssComponentAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_ServiceOfVssComponent", "Msvm_VssComponent", "Msvm_VssService", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmServiceOfVssComponentAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmVssService> Dependent(MsvmVssComponent inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVssService)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmVssComponent> Antecedent(MsvmVssService inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVssComponent)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmVssService> DependentAsync(MsvmVssComponent inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVssService)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmVssComponent> AntecedentAsync(MsvmVssService inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVssComponent)scope.Mapper.Create(scope, i));
        }
    }
}