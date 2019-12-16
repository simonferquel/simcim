using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmSystemComponentAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_SystemComponent", "CIM_System", "CIM_ManagedSystemElement", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MsvmSystemComponentAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMManagedSystemElement> PartComponent(CIMSystem inGroupComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance());
            return instances.Select(i => (CIMManagedSystemElement)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMSystem> GroupComponent(CIMManagedSystemElement inPartComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance());
            return instances.Select(i => (CIMSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMManagedSystemElement> PartComponentAsync(CIMSystem inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMManagedSystemElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMSystem> GroupComponentAsync(CIMManagedSystemElement inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMSystem)scope.Mapper.Create(scope, i));
        }
    }
}