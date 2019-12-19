using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmEthernetSwitchInfoAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_EthernetSwitchInfo", "Msvm_VirtualEthernetSwitch", "Msvm_EthernetSwitchData", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmEthernetSwitchInfoAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmEthernetSwitchData> Dependent(MsvmVirtualEthernetSwitch inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmEthernetSwitchData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmVirtualEthernetSwitch> Antecedent(MsvmEthernetSwitchData inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualEthernetSwitch)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmEthernetSwitchData> DependentAsync(MsvmVirtualEthernetSwitch inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmEthernetSwitchData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmVirtualEthernetSwitch> AntecedentAsync(MsvmEthernetSwitchData inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualEthernetSwitch)scope.Mapper.Create(scope, i));
        }
    }
}