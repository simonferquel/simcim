using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32NTLogEventComputerAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_NTLogEventComputer", "Win32_ComputerSystem", "Win32_NTLogEvent", "Computer", "Record");
        private IInfrastructureObjectScope _scope;
        public Win32NTLogEventComputerAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32NTLogEvent> Record(Win32ComputerSystem inComputer)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inComputer.AsCimInstance());
            return instances.Select(i => (Win32NTLogEvent)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32ComputerSystem> Computer(Win32NTLogEvent inRecord)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inRecord.AsCimInstance());
            return instances.Select(i => (Win32ComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32NTLogEvent> RecordAsync(Win32ComputerSystem inComputer, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inComputer.AsCimInstance(), options);
            return instances.Select(i => (Win32NTLogEvent)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ComputerSystem> ComputerAsync(Win32NTLogEvent inRecord, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inRecord.AsCimInstance(), options);
            return instances.Select(i => (Win32ComputerSystem)scope.Mapper.Create(scope, i));
        }
    }
}