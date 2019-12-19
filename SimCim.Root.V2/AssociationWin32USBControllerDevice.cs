using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32USBControllerDeviceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_USBControllerDevice", "CIM_USBController", "CIM_LogicalDevice", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32USBControllerDeviceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMLogicalDevice> Dependent(CIMUSBController inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMUSBController> Antecedent(CIMLogicalDevice inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMUSBController)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLogicalDevice> DependentAsync(CIMUSBController inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMUSBController> AntecedentAsync(CIMLogicalDevice inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMUSBController)scope.Mapper.Create(scope, i));
        }
    }
}