using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmParentChildSettingDataAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_ParentChildSettingData", "Msvm_VirtualSystemSettingData", "Msvm_VirtualSystemSettingData", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmParentChildSettingDataAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmVirtualSystemSettingData> Dependent(MsvmVirtualSystemSettingData inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (MsvmVirtualSystemSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmVirtualSystemSettingData> Antecedent(MsvmVirtualSystemSettingData inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (MsvmVirtualSystemSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmVirtualSystemSettingData> DependentAsync(MsvmVirtualSystemSettingData inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualSystemSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmVirtualSystemSettingData> AntecedentAsync(MsvmVirtualSystemSettingData inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmVirtualSystemSettingData)scope.Mapper.Create(scope, i));
        }
    }
}