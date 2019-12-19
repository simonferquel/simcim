using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct CIMMostCurrentSnapshotInBranchAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("CIM_MostCurrentSnapshotInBranch", "CIM_ComputerSystem", "CIM_VirtualSystemSettingData", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public CIMMostCurrentSnapshotInBranchAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMVirtualSystemSettingData> Dependent(CIMComputerSystem inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMVirtualSystemSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMComputerSystem> Antecedent(CIMVirtualSystemSettingData inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
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