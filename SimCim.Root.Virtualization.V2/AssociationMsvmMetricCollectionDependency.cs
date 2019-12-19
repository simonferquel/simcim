using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmMetricCollectionDependencyAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_MetricCollectionDependency", "CIM_ManagedElement", "CIM_ManagedElement", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmMetricCollectionDependencyAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMManagedElement> Dependent(CIMManagedElement inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMManagedElement> Antecedent(CIMManagedElement inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMManagedElement> DependentAsync(CIMManagedElement inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMManagedElement> AntecedentAsync(CIMManagedElement inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMManagedElement)scope.Mapper.Create(scope, i));
        }
    }
}