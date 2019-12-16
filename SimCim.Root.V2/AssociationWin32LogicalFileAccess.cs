using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32LogicalFileAccessAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_LogicalFileAccess", "Win32_LogicalFileSecuritySetting", "Win32_SID", "SecuritySetting", "Trustee");
        private IInfrastructureObjectScope _scope;
        public Win32LogicalFileAccessAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32SID> Trustee(Win32LogicalFileSecuritySetting inSecuritySetting)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inSecuritySetting.AsCimInstance());
            return instances.Select(i => (Win32SID)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32LogicalFileSecuritySetting> SecuritySetting(Win32SID inTrustee)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inTrustee.AsCimInstance());
            return instances.Select(i => (Win32LogicalFileSecuritySetting)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SID> TrusteeAsync(Win32LogicalFileSecuritySetting inSecuritySetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inSecuritySetting.AsCimInstance(), options);
            return instances.Select(i => (Win32SID)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32LogicalFileSecuritySetting> SecuritySettingAsync(Win32SID inTrustee, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inTrustee.AsCimInstance(), options);
            return instances.Select(i => (Win32LogicalFileSecuritySetting)scope.Mapper.Create(scope, i));
        }
    }
}