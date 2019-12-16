using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmElementAllocatedFromNumaNodeAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_ElementAllocatedFromNumaNode", "Msvm_NumaNode", "CIM_LogicalElement", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmElementAllocatedFromNumaNodeAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMLogicalElement> Dependent(MsvmNumaNode inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (CIMLogicalElement)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmNumaNode> Antecedent(CIMLogicalElement inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (MsvmNumaNode)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLogicalElement> DependentAsync(MsvmNumaNode inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmNumaNode> AntecedentAsync(CIMLogicalElement inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmNumaNode)scope.Mapper.Create(scope, i));
        }
    }
}