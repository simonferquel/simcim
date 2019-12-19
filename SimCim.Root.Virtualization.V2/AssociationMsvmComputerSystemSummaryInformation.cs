using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmComputerSystemSummaryInformationAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_ComputerSystemSummaryInformation", "CIM_ComputerSystem", "Msvm_SummaryInformationBase", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmComputerSystemSummaryInformationAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmSummaryInformationBase> Dependent(CIMComputerSystem inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmSummaryInformationBase)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMComputerSystem> Antecedent(MsvmSummaryInformationBase inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmSummaryInformationBase> DependentAsync(CIMComputerSystem inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmSummaryInformationBase)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMComputerSystem> AntecedentAsync(MsvmSummaryInformationBase inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMComputerSystem)scope.Mapper.Create(scope, i));
        }
    }
}