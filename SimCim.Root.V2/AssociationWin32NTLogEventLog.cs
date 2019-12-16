using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32NTLogEventLogAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_NTLogEventLog", "Win32_NTEventlogFile", "Win32_NTLogEvent", "Log", "Record");
        private IInfrastructureObjectScope _scope;
        public Win32NTLogEventLogAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32NTLogEvent> Record(Win32NTEventlogFile inLog)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inLog.AsCimInstance());
            return instances.Select(i => (Win32NTLogEvent)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32NTEventlogFile> Log(Win32NTLogEvent inRecord)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inRecord.AsCimInstance());
            return instances.Select(i => (Win32NTEventlogFile)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32NTLogEvent> RecordAsync(Win32NTEventlogFile inLog, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inLog.AsCimInstance(), options);
            return instances.Select(i => (Win32NTLogEvent)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32NTEventlogFile> LogAsync(Win32NTLogEvent inRecord, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inRecord.AsCimInstance(), options);
            return instances.Select(i => (Win32NTEventlogFile)scope.Mapper.Create(scope, i));
        }
    }
}