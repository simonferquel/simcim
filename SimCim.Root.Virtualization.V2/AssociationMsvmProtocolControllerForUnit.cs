using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmProtocolControllerForUnitAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_ProtocolControllerForUnit", "CIM_ProtocolController", "CIM_LogicalDevice", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmProtocolControllerForUnitAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMLogicalDevice> Dependent(CIMProtocolController inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMProtocolController> Antecedent(CIMLogicalDevice inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMProtocolController)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLogicalDevice> DependentAsync(CIMProtocolController inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMProtocolController> AntecedentAsync(CIMLogicalDevice inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMProtocolController)scope.Mapper.Create(scope, i));
        }
    }
}