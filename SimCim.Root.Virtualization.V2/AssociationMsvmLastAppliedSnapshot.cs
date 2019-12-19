using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmLastAppliedSnapshotAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_LastAppliedSnapshot", "CIM_VirtualSystemSettingData", "CIM_ComputerSystem", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmLastAppliedSnapshotAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMComputerSystem> Dependent(CIMVirtualSystemSettingData inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMVirtualSystemSettingData> Antecedent(CIMComputerSystem inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMVirtualSystemSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMComputerSystem> DependentAsync(CIMVirtualSystemSettingData inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMVirtualSystemSettingData> AntecedentAsync(CIMComputerSystem inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMVirtualSystemSettingData)scope.Mapper.Create(scope, i));
        }
    }
}