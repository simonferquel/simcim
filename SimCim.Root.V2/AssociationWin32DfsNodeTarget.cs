using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32DfsNodeTargetAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_DfsNodeTarget", "Win32_DfsTarget", "Win32_DfsNode", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32DfsNodeTargetAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32DfsNode> Dependent(Win32DfsTarget inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32DfsNode)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32DfsTarget> Antecedent(Win32DfsNode inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32DfsTarget)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32DfsNode> DependentAsync(Win32DfsTarget inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32DfsNode)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32DfsTarget> AntecedentAsync(Win32DfsNode inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32DfsTarget)scope.Mapper.Create(scope, i));
        }
    }
}