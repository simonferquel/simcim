using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win321394ControllerDeviceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_1394ControllerDevice", "Win32_1394Controller", "CIM_LogicalDevice", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win321394ControllerDeviceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMLogicalDevice> Dependent(Win321394Controller inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win321394Controller> Antecedent(CIMLogicalDevice inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win321394Controller)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLogicalDevice> DependentAsync(Win321394Controller inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win321394Controller> AntecedentAsync(CIMLogicalDevice inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win321394Controller)scope.Mapper.Create(scope, i));
        }
    }
}