using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ShareToDirectoryAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ShareToDirectory", "Win32_Share", "CIM_Directory", "Share", "SharedElement");
        private IInfrastructureObjectScope _scope;
        public Win32ShareToDirectoryAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMDirectory> SharedElement(Win32Share inShare)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inShare.AsCimInstance());
            return instances.Select(i => (CIMDirectory)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32Share> Share(CIMDirectory inSharedElement)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSharedElement.AsCimInstance());
            return instances.Select(i => (Win32Share)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMDirectory> SharedElementAsync(Win32Share inShare, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inShare.AsCimInstance(), options);
            return instances.Select(i => (CIMDirectory)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Share> ShareAsync(CIMDirectory inSharedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSharedElement.AsCimInstance(), options);
            return instances.Select(i => (Win32Share)scope.Mapper.Create(scope, i));
        }
    }
}