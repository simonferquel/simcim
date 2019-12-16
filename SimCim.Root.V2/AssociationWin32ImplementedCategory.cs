using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ImplementedCategoryAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ImplementedCategory", "Win32_ComponentCategory", "Win32_ClassicCOMClass", "Category", "Component");
        private IInfrastructureObjectScope _scope;
        public Win32ImplementedCategoryAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32ClassicCOMClass> Component(Win32ComponentCategory inCategory)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inCategory.AsCimInstance());
            return instances.Select(i => (Win32ClassicCOMClass)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32ComponentCategory> Category(Win32ClassicCOMClass inComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inComponent.AsCimInstance());
            return instances.Select(i => (Win32ComponentCategory)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ClassicCOMClass> ComponentAsync(Win32ComponentCategory inCategory, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inCategory.AsCimInstance(), options);
            return instances.Select(i => (Win32ClassicCOMClass)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ComponentCategory> CategoryAsync(Win32ClassicCOMClass inComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32ComponentCategory)scope.Mapper.Create(scope, i));
        }
    }
}