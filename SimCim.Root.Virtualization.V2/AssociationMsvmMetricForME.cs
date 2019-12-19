using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmMetricForMEAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_MetricForME", "CIM_ManagedElement", "CIM_BaseMetricValue", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmMetricForMEAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMBaseMetricValue> Dependent(CIMManagedElement inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMBaseMetricValue)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMManagedElement> Antecedent(CIMBaseMetricValue inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMBaseMetricValue> DependentAsync(CIMManagedElement inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMBaseMetricValue)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMManagedElement> AntecedentAsync(CIMBaseMetricValue inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }
    }
}