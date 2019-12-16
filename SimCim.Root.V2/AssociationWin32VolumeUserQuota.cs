using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32VolumeUserQuotaAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_VolumeUserQuota", "Win32_Account", "Win32_Volume", "Account", "Volume");
        private IInfrastructureObjectScope _scope;
        public Win32VolumeUserQuotaAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Volume> Volume(Win32Account inAccount)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAccount.AsCimInstance());
            return instances.Select(i => (Win32Volume)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32Account> Account(Win32Volume inVolume)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inVolume.AsCimInstance());
            return instances.Select(i => (Win32Account)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Volume> VolumeAsync(Win32Account inAccount, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAccount.AsCimInstance(), options);
            return instances.Select(i => (Win32Volume)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Account> AccountAsync(Win32Volume inVolume, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inVolume.AsCimInstance(), options);
            return instances.Select(i => (Win32Account)scope.Mapper.Create(scope, i));
        }
    }
}