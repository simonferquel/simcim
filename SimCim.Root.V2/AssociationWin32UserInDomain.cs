using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32UserInDomainAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_UserInDomain", "Win32_NTDomain", "Win32_UserAccount", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public Win32UserInDomainAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32UserAccount> PartComponent(Win32NTDomain inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32UserAccount)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32NTDomain> GroupComponent(Win32UserAccount inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32NTDomain)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32UserAccount> PartComponentAsync(Win32NTDomain inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32UserAccount)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32NTDomain> GroupComponentAsync(Win32UserAccount inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (Win32NTDomain)scope.Mapper.Create(scope, i));
        }
    }
}