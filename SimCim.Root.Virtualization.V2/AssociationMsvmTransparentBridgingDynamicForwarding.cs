using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmTransparentBridgingDynamicForwardingAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_TransparentBridgingDynamicForwarding", "Msvm_TransparentBridgingService", "Msvm_DynamicForwardingEntry", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmTransparentBridgingDynamicForwardingAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmDynamicForwardingEntry> Dependent(MsvmTransparentBridgingService inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (MsvmDynamicForwardingEntry)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmTransparentBridgingService> Antecedent(MsvmDynamicForwardingEntry inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (MsvmTransparentBridgingService)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmDynamicForwardingEntry> DependentAsync(MsvmTransparentBridgingService inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmDynamicForwardingEntry)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmTransparentBridgingService> AntecedentAsync(MsvmDynamicForwardingEntry inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmTransparentBridgingService)scope.Mapper.Create(scope, i));
        }
    }
}