using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmMetricDefForMEAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_MetricDefForME", "CIM_ManagedElement", "CIM_BaseMetricDefinition", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmMetricDefForMEAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMBaseMetricDefinition> Dependent(CIMManagedElement inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMBaseMetricDefinition)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMManagedElement> Antecedent(CIMBaseMetricDefinition inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMBaseMetricDefinition> DependentAsync(CIMManagedElement inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMBaseMetricDefinition)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMManagedElement> AntecedentAsync(CIMBaseMetricDefinition inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }
    }
}