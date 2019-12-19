using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SCSIControllerDeviceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SCSIControllerDevice", "Win32_SCSIController", "CIM_LogicalDevice", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32SCSIControllerDeviceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMLogicalDevice> Dependent(Win32SCSIController inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32SCSIController> Antecedent(CIMLogicalDevice inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32SCSIController)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLogicalDevice> DependentAsync(Win32SCSIController inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SCSIController> AntecedentAsync(CIMLogicalDevice inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32SCSIController)scope.Mapper.Create(scope, i));
        }
    }
}