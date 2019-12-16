using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ODBCDriverAttributeAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ODBCDriverAttribute", "Win32_ODBCDriverSpecification", "Win32_ODBCAttribute", "Check", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32ODBCDriverAttributeAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32ODBCAttribute> Setting(Win32ODBCDriverSpecification inCheck)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCheck.AsCimInstance());
            return instances.Select(i => (Win32ODBCAttribute)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32ODBCDriverSpecification> Check(Win32ODBCAttribute inSetting)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance());
            return instances.Select(i => (Win32ODBCDriverSpecification)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ODBCAttribute> SettingAsync(Win32ODBCDriverSpecification inCheck, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCheck.AsCimInstance(), options);
            return instances.Select(i => (Win32ODBCAttribute)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ODBCDriverSpecification> CheckAsync(Win32ODBCAttribute inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32ODBCDriverSpecification)scope.Mapper.Create(scope, i));
        }
    }
}