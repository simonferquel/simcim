using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmReferencePointOfVirtualSystemAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_ReferencePointOfVirtualSystem", "Msvm_ComputerSystem", "Msvm_VirtualSystemReferencePoint", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmReferencePointOfVirtualSystemAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmVirtualSystemReferencePoint> Dependent(MsvmComputerSystem inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualSystemReferencePoint)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmComputerSystem> Antecedent(MsvmVirtualSystemReferencePoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmVirtualSystemReferencePoint> DependentAsync(MsvmComputerSystem inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualSystemReferencePoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmComputerSystem> AntecedentAsync(MsvmVirtualSystemReferencePoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmComputerSystem)scope.Mapper.Create(scope, i));
        }
    }
}