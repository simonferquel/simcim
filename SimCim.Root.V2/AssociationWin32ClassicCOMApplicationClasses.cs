using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ClassicCOMApplicationClassesAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ClassicCOMApplicationClasses", "Win32_DCOMApplication", "Win32_ClassicCOMClass", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public Win32ClassicCOMApplicationClassesAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32ClassicCOMClass> PartComponent(Win32DCOMApplication inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32ClassicCOMClass)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32DCOMApplication> GroupComponent(Win32ClassicCOMClass inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32DCOMApplication)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ClassicCOMClass> PartComponentAsync(Win32DCOMApplication inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32ClassicCOMClass)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32DCOMApplication> GroupComponentAsync(Win32ClassicCOMClass inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32DCOMApplication)scope.Mapper.Create(scope, i));
        }
    }
}