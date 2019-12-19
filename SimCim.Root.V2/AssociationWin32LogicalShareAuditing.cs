using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32LogicalShareAuditingAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_LogicalShareAuditing", "Win32_LogicalShareSecuritySetting", "Win32_SID", "SecuritySetting", "Trustee");
        private IInfrastructureObjectScope _scope;
        public Win32LogicalShareAuditingAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32SID> Trustee(Win32LogicalShareSecuritySetting inSecuritySetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inSecuritySetting.AsCimInstance(), options);
            return instances.Select(i => (Win32SID)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32LogicalShareSecuritySetting> SecuritySetting(Win32SID inTrustee, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inTrustee.AsCimInstance(), options);
            return instances.Select(i => (Win32LogicalShareSecuritySetting)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SID> TrusteeAsync(Win32LogicalShareSecuritySetting inSecuritySetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inSecuritySetting.AsCimInstance(), options);
            return instances.Select(i => (Win32SID)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32LogicalShareSecuritySetting> SecuritySettingAsync(Win32SID inTrustee, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inTrustee.AsCimInstance(), options);
            return instances.Select(i => (Win32LogicalShareSecuritySetting)scope.Mapper.Create(scope, i));
        }
    }
}