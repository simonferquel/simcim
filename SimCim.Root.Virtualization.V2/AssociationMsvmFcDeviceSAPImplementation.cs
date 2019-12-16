using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmFcDeviceSAPImplementationAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_FcDeviceSAPImplementation", "CIM_FCPort", "Msvm_FcEndpoint", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmFcDeviceSAPImplementationAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmFcEndpoint> Dependent(CIMFCPort inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (MsvmFcEndpoint)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMFCPort> Antecedent(MsvmFcEndpoint inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (CIMFCPort)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmFcEndpoint> DependentAsync(CIMFCPort inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmFcEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMFCPort> AntecedentAsync(MsvmFcEndpoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMFCPort)scope.Mapper.Create(scope, i));
        }
    }
}