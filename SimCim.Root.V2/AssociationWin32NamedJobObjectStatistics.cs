using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32NamedJobObjectStatisticsAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_NamedJobObjectStatistics", "Win32_NamedJobObject", "Win32_NamedJobObjectActgInfo", "Collection", "Stats");
        private IInfrastructureObjectScope _scope;
        public Win32NamedJobObjectStatisticsAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32NamedJobObjectActgInfo> Stats(Win32NamedJobObject inCollection)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCollection.AsCimInstance());
            return instances.Select(i => (Win32NamedJobObjectActgInfo)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32NamedJobObject> Collection(Win32NamedJobObjectActgInfo inStats)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inStats.AsCimInstance());
            return instances.Select(i => (Win32NamedJobObject)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32NamedJobObjectActgInfo> StatsAsync(Win32NamedJobObject inCollection, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCollection.AsCimInstance(), options);
            return instances.Select(i => (Win32NamedJobObjectActgInfo)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32NamedJobObject> CollectionAsync(Win32NamedJobObjectActgInfo inStats, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inStats.AsCimInstance(), options);
            return instances.Select(i => (Win32NamedJobObject)scope.Mapper.Create(scope, i));
        }
    }
}