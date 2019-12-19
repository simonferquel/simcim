using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmMostCurrentSnapshotInBranchAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_MostCurrentSnapshotInBranch", "CIM_ComputerSystem", "Msvm_VirtualSystemSettingData", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmMostCurrentSnapshotInBranchAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmVirtualSystemSettingData> Dependent(CIMComputerSystem inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualSystemSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMComputerSystem> Antecedent(MsvmVirtualSystemSettingData inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmVirtualSystemSettingData> DependentAsync(CIMComputerSystem inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualSystemSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMComputerSystem> AntecedentAsync(MsvmVirtualSystemSettingData inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMComputerSystem)scope.Mapper.Create(scope, i));
        }
    }
}