using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmBindsToLANEndpointAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_BindsToLANEndpoint", "Msvm_LANEndpoint", "Msvm_VLANEndpoint", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmBindsToLANEndpointAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmVLANEndpoint> Dependent(MsvmLANEndpoint inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVLANEndpoint)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmLANEndpoint> Antecedent(MsvmVLANEndpoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmLANEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmVLANEndpoint> DependentAsync(MsvmLANEndpoint inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVLANEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmLANEndpoint> AntecedentAsync(MsvmVLANEndpoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmLANEndpoint)scope.Mapper.Create(scope, i));
        }
    }
}