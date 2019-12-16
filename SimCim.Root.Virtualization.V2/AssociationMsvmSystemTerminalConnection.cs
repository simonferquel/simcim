using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmSystemTerminalConnectionAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_SystemTerminalConnection", "Msvm_ComputerSystem", "Msvm_TerminalConnection", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmSystemTerminalConnectionAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmTerminalConnection> Dependent(MsvmComputerSystem inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (MsvmTerminalConnection)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmComputerSystem> Antecedent(MsvmTerminalConnection inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (MsvmComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmTerminalConnection> DependentAsync(MsvmComputerSystem inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmTerminalConnection)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmComputerSystem> AntecedentAsync(MsvmTerminalConnection inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmComputerSystem)scope.Mapper.Create(scope, i));
        }
    }
}