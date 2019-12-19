using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32NTLogEventUserAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_NTLogEventUser", "Win32_NTLogEvent", "Win32_UserAccount", "Record", "User");
        private IInfrastructureObjectScope _scope;
        public Win32NTLogEventUserAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32UserAccount> User(Win32NTLogEvent inRecord, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inRecord.AsCimInstance(), options);
            return instances.Select(i => (Win32UserAccount)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32NTLogEvent> Record(Win32UserAccount inUser, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inUser.AsCimInstance(), options);
            return instances.Select(i => (Win32NTLogEvent)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32UserAccount> UserAsync(Win32NTLogEvent inRecord, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inRecord.AsCimInstance(), options);
            return instances.Select(i => (Win32UserAccount)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32NTLogEvent> RecordAsync(Win32UserAccount inUser, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inUser.AsCimInstance(), options);
            return instances.Select(i => (Win32NTLogEvent)scope.Mapper.Create(scope, i));
        }
    }
}