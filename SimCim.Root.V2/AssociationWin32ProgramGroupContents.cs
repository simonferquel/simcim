using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ProgramGroupContentsAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ProgramGroupContents", "Win32_LogicalProgramGroup", "Win32_ProgramGroupOrItem", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public Win32ProgramGroupContentsAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32ProgramGroupOrItem> PartComponent(Win32LogicalProgramGroup inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32ProgramGroupOrItem)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32LogicalProgramGroup> GroupComponent(Win32ProgramGroupOrItem inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32LogicalProgramGroup)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ProgramGroupOrItem> PartComponentAsync(Win32LogicalProgramGroup inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32ProgramGroupOrItem)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32LogicalProgramGroup> GroupComponentAsync(Win32ProgramGroupOrItem inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32LogicalProgramGroup)scope.Mapper.Create(scope, i));
        }
    }
}