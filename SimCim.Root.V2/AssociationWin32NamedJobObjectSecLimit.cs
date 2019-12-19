using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32NamedJobObjectSecLimitAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_NamedJobObjectSecLimit", "Win32_NamedJobObject", "Win32_NamedJobObjectSecLimitSetting", "Collection", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32NamedJobObjectSecLimitAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32NamedJobObjectSecLimitSetting> Setting(Win32NamedJobObject inCollection, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCollection.AsCimInstance(), options);
            return instances.Select(i => (Win32NamedJobObjectSecLimitSetting)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32NamedJobObject> Collection(Win32NamedJobObjectSecLimitSetting inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32NamedJobObject)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32NamedJobObjectSecLimitSetting> SettingAsync(Win32NamedJobObject inCollection, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCollection.AsCimInstance(), options);
            return instances.Select(i => (Win32NamedJobObjectSecLimitSetting)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32NamedJobObject> CollectionAsync(Win32NamedJobObjectSecLimitSetting inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32NamedJobObject)scope.Mapper.Create(scope, i));
        }
    }
}