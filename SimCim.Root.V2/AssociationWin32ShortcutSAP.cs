using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ShortcutSAPAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ShortcutSAP", "Win32_ShortcutAction", "Win32_CommandLineAccess", "Action", "Element");
        private IInfrastructureObjectScope _scope;
        public Win32ShortcutSAPAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32CommandLineAccess> Element(Win32ShortcutAction inAction, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAction.AsCimInstance(), options);
            return instances.Select(i => (Win32CommandLineAccess)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32ShortcutAction> Action(Win32CommandLineAccess inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32ShortcutAction)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32CommandLineAccess> ElementAsync(Win32ShortcutAction inAction, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAction.AsCimInstance(), options);
            return instances.Select(i => (Win32CommandLineAccess)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32ShortcutAction> ActionAsync(Win32CommandLineAccess inElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inElement.AsCimInstance(), options);
            return instances.Select(i => (Win32ShortcutAction)scope.Mapper.Create(scope, i));
        }
    }
}