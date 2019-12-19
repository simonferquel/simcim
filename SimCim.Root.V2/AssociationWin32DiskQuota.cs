using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32DiskQuotaAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_DiskQuota", "Win32_LogicalDisk", "Win32_Account", "QuotaVolume", "User");
        private IInfrastructureObjectScope _scope;
        public Win32DiskQuotaAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Account> User(Win32LogicalDisk inQuotaVolume, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inQuotaVolume.AsCimInstance(), options);
            return instances.Select(i => (Win32Account)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32LogicalDisk> QuotaVolume(Win32Account inUser, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inUser.AsCimInstance(), options);
            return instances.Select(i => (Win32LogicalDisk)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Account> UserAsync(Win32LogicalDisk inQuotaVolume, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inQuotaVolume.AsCimInstance(), options);
            return instances.Select(i => (Win32Account)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32LogicalDisk> QuotaVolumeAsync(Win32Account inUser, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inUser.AsCimInstance(), options);
            return instances.Select(i => (Win32LogicalDisk)scope.Mapper.Create(scope, i));
        }
    }
}