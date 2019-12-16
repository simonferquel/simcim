using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ODBCDataSourceAttributeAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ODBCDataSourceAttribute", "Win32_ODBCDataSourceSpecification", "Win32_ODBCSourceAttribute", "Check", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32ODBCDataSourceAttributeAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32ODBCSourceAttribute> Setting(Win32ODBCDataSourceSpecification inCheck)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCheck.AsCimInstance());
            return instances.Select(i => (Win32ODBCSourceAttribute)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32ODBCDataSourceSpecification> Check(Win32ODBCSourceAttribute inSetting)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance());
            return instances.Select(i => (Win32ODBCDataSourceSpecification)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ODBCSourceAttribute> SettingAsync(Win32ODBCDataSourceSpecification inCheck, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCheck.AsCimInstance(), options);
            return instances.Select(i => (Win32ODBCSourceAttribute)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ODBCDataSourceSpecification> CheckAsync(Win32ODBCSourceAttribute inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32ODBCDataSourceSpecification)scope.Mapper.Create(scope, i));
        }
    }
}