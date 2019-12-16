using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetEventCaptureTargetCaptureProviderAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetEventCaptureTarget_CaptureProvider", "MSFT_NetEventPacketCaptureProvider", "MSFT_NetEventPacketCaptureTarget", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetEventCaptureTargetCaptureProviderAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetEventPacketCaptureTarget> PartComponent(MSFTNetEventPacketCaptureProvider inGroupComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance());
            return instances.Select(i => (MSFTNetEventPacketCaptureTarget)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetEventPacketCaptureProvider> GroupComponent(MSFTNetEventPacketCaptureTarget inPartComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance());
            return instances.Select(i => (MSFTNetEventPacketCaptureProvider)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetEventPacketCaptureTarget> PartComponentAsync(MSFTNetEventPacketCaptureProvider inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetEventPacketCaptureTarget)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetEventPacketCaptureProvider> GroupComponentAsync(MSFTNetEventPacketCaptureTarget inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetEventPacketCaptureProvider)scope.Mapper.Create(scope, i));
        }
    }
}