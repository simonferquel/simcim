using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmSystemBIOSAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_SystemBIOS", "CIM_ComputerSystem", "Msvm_BIOSElement", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MsvmSystemBIOSAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmBIOSElement> PartComponent(CIMComputerSystem inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MsvmBIOSElement)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMComputerSystem> GroupComponent(MsvmBIOSElement inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmBIOSElement> PartComponentAsync(CIMComputerSystem inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MsvmBIOSElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMComputerSystem> GroupComponentAsync(MsvmBIOSElement inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMComputerSystem)scope.Mapper.Create(scope, i));
        }
    }
}