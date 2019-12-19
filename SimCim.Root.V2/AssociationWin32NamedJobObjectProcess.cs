using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32NamedJobObjectProcessAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_NamedJobObjectProcess", "Win32_NamedJobObject", "Win32_Process", "Collection", "Member");
        private IInfrastructureObjectScope _scope;
        public Win32NamedJobObjectProcessAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Process> Member(Win32NamedJobObject inCollection, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCollection.AsCimInstance(), options);
            return instances.Select(i => (Win32Process)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32NamedJobObject> Collection(Win32Process inMember, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inMember.AsCimInstance(), options);
            return instances.Select(i => (Win32NamedJobObject)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Process> MemberAsync(Win32NamedJobObject inCollection, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCollection.AsCimInstance(), options);
            return instances.Select(i => (Win32Process)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32NamedJobObject> CollectionAsync(Win32Process inMember, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inMember.AsCimInstance(), options);
            return instances.Select(i => (Win32NamedJobObject)scope.Mapper.Create(scope, i));
        }
    }
}