﻿using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetMainModeRuleMMAuthSetAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetMainModeRuleMMAuthSet", "MSFT_NetMainModeRule", "MSFT_NetIKEP1AuthSet", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetMainModeRuleMMAuthSetAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetIKEP1AuthSet> PartComponent(MSFTNetMainModeRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetIKEP1AuthSet)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetMainModeRule> GroupComponent(MSFTNetIKEP1AuthSet inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetMainModeRule)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetIKEP1AuthSet> PartComponentAsync(MSFTNetMainModeRule inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetIKEP1AuthSet)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetMainModeRule> GroupComponentAsync(MSFTNetIKEP1AuthSet inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetMainModeRule)scope.Mapper.Create(scope, i));
        }
    }
}