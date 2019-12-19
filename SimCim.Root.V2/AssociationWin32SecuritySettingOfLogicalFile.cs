using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SecuritySettingOfLogicalFileAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SecuritySettingOfLogicalFile", "CIM_LogicalFile", "Win32_LogicalFileSecuritySetting", "Element", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32SecuritySettingOfLogicalFileAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32LogicalFileSecuritySetting> Setting(CIMLogicalFile inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32LogicalFileSecuritySetting)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMLogicalFile> Element(Win32LogicalFileSecuritySetting inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalFile)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32LogicalFileSecuritySetting> SettingAsync(CIMLogicalFile inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32LogicalFileSecuritySetting)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLogicalFile> ElementAsync(Win32LogicalFileSecuritySetting inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalFile)scope.Mapper.Create(scope, i));
        }
    }
}