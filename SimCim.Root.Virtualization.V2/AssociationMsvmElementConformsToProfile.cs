using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmElementConformsToProfileAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_ElementConformsToProfile", "Msvm_RegisteredProfile", "Msvm_ComputerSystem", "ConformantStandard", "ManagedElement");
        private IInfrastructureObjectScope _scope;
        public MsvmElementConformsToProfileAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmComputerSystem> ManagedElement(CimInstance inConformantStandard, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inConformantStandard, options);
            return instances.Select(i => (MsvmComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CimInstance> ConformantStandard(MsvmComputerSystem inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inManagedElement.AsCimInstance(), options);
            return instances;
        }

        public IObservable<MsvmComputerSystem> ManagedElementAsync(CimInstance inConformantStandard, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inConformantStandard, options);
            return instances.Select(i => (MsvmComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<CimInstance> ConformantStandardAsync(MsvmComputerSystem inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inManagedElement.AsCimInstance(), options);
            return instances;
        }
    }
}