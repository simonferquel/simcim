using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32AllocatedResourceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_AllocatedResource", "CIM_SystemResource", "CIM_LogicalDevice", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32AllocatedResourceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMLogicalDevice> Dependent(CIMSystemResource inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMSystemResource> Antecedent(CIMLogicalDevice inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMSystemResource)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLogicalDevice> DependentAsync(CIMSystemResource inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMSystemResource> AntecedentAsync(CIMLogicalDevice inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMSystemResource)scope.Mapper.Create(scope, i));
        }
    }
}