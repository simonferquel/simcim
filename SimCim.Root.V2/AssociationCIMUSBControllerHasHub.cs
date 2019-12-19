using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct CIMUSBControllerHasHubAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("CIM_USBControllerHasHub", "CIM_USBController", "CIM_USBHub", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public CIMUSBControllerHasHubAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMUSBHub> Dependent(CIMUSBController inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMUSBHub)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMUSBController> Antecedent(CIMUSBHub inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMUSBController)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMUSBHub> DependentAsync(CIMUSBController inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMUSBHub)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMUSBController> AntecedentAsync(CIMUSBHub inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMUSBController)scope.Mapper.Create(scope, i));
        }
    }
}