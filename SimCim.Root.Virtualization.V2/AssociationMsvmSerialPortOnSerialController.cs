using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmSerialPortOnSerialControllerAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_SerialPortOnSerialController", "CIM_LogicalDevice", "CIM_LogicalPort", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmSerialPortOnSerialControllerAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMLogicalPort> Dependent(CIMLogicalDevice inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalPort)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMLogicalDevice> Antecedent(CIMLogicalPort inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLogicalPort> DependentAsync(CIMLogicalDevice inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalPort)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLogicalDevice> AntecedentAsync(CIMLogicalPort inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }
    }
}