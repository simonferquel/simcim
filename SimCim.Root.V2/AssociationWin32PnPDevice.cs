using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32PnPDeviceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_PnPDevice", "CIM_LogicalDevice", "Win32_PnPEntity", "SameElement", "SystemElement");
        private IInfrastructureObjectScope _scope;
        public Win32PnPDeviceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32PnPEntity> SystemElement(CIMLogicalDevice inSameElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inSameElement.AsCimInstance());
            return instances.Select(i => (Win32PnPEntity)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMLogicalDevice> SameElement(Win32PnPEntity inSystemElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSystemElement.AsCimInstance());
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32PnPEntity> SystemElementAsync(CIMLogicalDevice inSameElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inSameElement.AsCimInstance(), options);
            return instances.Select(i => (Win32PnPEntity)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLogicalDevice> SameElementAsync(Win32PnPEntity inSystemElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSystemElement.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }
    }
}