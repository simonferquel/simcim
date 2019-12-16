using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32LogicalFileOwnerAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_LogicalFileOwner", "Win32_SID", "Win32_LogicalFileSecuritySetting", "Owner", "SecuritySetting");
        private IInfrastructureObjectScope _scope;
        public Win32LogicalFileOwnerAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32LogicalFileSecuritySetting> SecuritySetting(Win32SID inOwner)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inOwner.AsCimInstance());
            return instances.Select(i => (Win32LogicalFileSecuritySetting)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32SID> Owner(Win32LogicalFileSecuritySetting inSecuritySetting)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSecuritySetting.AsCimInstance());
            return instances.Select(i => (Win32SID)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32LogicalFileSecuritySetting> SecuritySettingAsync(Win32SID inOwner, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inOwner.AsCimInstance(), options);
            return instances.Select(i => (Win32LogicalFileSecuritySetting)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SID> OwnerAsync(Win32LogicalFileSecuritySetting inSecuritySetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSecuritySetting.AsCimInstance(), options);
            return instances.Select(i => (Win32SID)scope.Mapper.Create(scope, i));
        }
    }
}