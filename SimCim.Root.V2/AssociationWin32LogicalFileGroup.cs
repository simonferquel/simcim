using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32LogicalFileGroupAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_LogicalFileGroup", "Win32_SID", "Win32_LogicalFileSecuritySetting", "Group", "SecuritySetting");
        private IInfrastructureObjectScope _scope;
        public Win32LogicalFileGroupAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32LogicalFileSecuritySetting> SecuritySetting(Win32SID inGroup)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroup.AsCimInstance());
            return instances.Select(i => (Win32LogicalFileSecuritySetting)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32SID> Group(Win32LogicalFileSecuritySetting inSecuritySetting)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSecuritySetting.AsCimInstance());
            return instances.Select(i => (Win32SID)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32LogicalFileSecuritySetting> SecuritySettingAsync(Win32SID inGroup, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroup.AsCimInstance(), options);
            return instances.Select(i => (Win32LogicalFileSecuritySetting)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SID> GroupAsync(Win32LogicalFileSecuritySetting inSecuritySetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSecuritySetting.AsCimInstance(), options);
            return instances.Select(i => (Win32SID)scope.Mapper.Create(scope, i));
        }
    }
}