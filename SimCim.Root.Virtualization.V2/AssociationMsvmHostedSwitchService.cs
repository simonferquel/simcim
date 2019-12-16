using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmHostedSwitchServiceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_HostedSwitchService", "Msvm_VirtualEthernetSwitch", "CIM_Service", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmHostedSwitchServiceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMService> Dependent(MsvmVirtualEthernetSwitch inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (CIMService)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmVirtualEthernetSwitch> Antecedent(CIMService inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (MsvmVirtualEthernetSwitch)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMService> DependentAsync(MsvmVirtualEthernetSwitch inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMService)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmVirtualEthernetSwitch> AntecedentAsync(CIMService inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualEthernetSwitch)scope.Mapper.Create(scope, i));
        }
    }
}