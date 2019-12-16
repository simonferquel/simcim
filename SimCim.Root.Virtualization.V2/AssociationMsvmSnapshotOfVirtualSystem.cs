using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmSnapshotOfVirtualSystemAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_SnapshotOfVirtualSystem", "CIM_ComputerSystem", "CIM_VirtualSystemSettingData", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmSnapshotOfVirtualSystemAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMVirtualSystemSettingData> Dependent(CIMComputerSystem inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (CIMVirtualSystemSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMComputerSystem> Antecedent(CIMVirtualSystemSettingData inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (CIMComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMVirtualSystemSettingData> DependentAsync(CIMComputerSystem inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMVirtualSystemSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMComputerSystem> AntecedentAsync(CIMVirtualSystemSettingData inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMComputerSystem)scope.Mapper.Create(scope, i));
        }
    }
}