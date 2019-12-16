using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32NamedJobObjectLimitAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_NamedJobObjectLimit", "Win32_NamedJobObject", "Win32_NamedJobObjectLimitSetting", "Collection", "Setting");
        private IInfrastructureObjectScope _scope;
        public Win32NamedJobObjectLimitAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32NamedJobObjectLimitSetting> Setting(Win32NamedJobObject inCollection)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCollection.AsCimInstance());
            return instances.Select(i => (Win32NamedJobObjectLimitSetting)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32NamedJobObject> Collection(Win32NamedJobObjectLimitSetting inSetting)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSetting.AsCimInstance());
            return instances.Select(i => (Win32NamedJobObject)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32NamedJobObjectLimitSetting> SettingAsync(Win32NamedJobObject inCollection, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCollection.AsCimInstance(), options);
            return instances.Select(i => (Win32NamedJobObjectLimitSetting)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32NamedJobObject> CollectionAsync(Win32NamedJobObjectLimitSetting inSetting, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSetting.AsCimInstance(), options);
            return instances.Select(i => (Win32NamedJobObject)scope.Mapper.Create(scope, i));
        }
    }
}