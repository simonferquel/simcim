using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct FilterToConsumerBindingAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("__FilterToConsumerBinding", "__EventConsumer", "__EventFilter", "Consumer", "Filter");
        private IInfrastructureObjectScope _scope;
        public FilterToConsumerBindingAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<EventFilter> Filter(EventConsumer inConsumer, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inConsumer.AsCimInstance(), options);
            return instances.Select(i => (EventFilter)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<EventConsumer> Consumer(EventFilter inFilter, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inFilter.AsCimInstance(), options);
            return instances.Select(i => (EventConsumer)scope.Mapper.Create(scope, i));
        }

        public IObservable<EventFilter> FilterAsync(EventConsumer inConsumer, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inConsumer.AsCimInstance(), options);
            return instances.Select(i => (EventFilter)scope.Mapper.Create(scope, i));
        }

        public IObservable<EventConsumer> ConsumerAsync(EventFilter inFilter, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inFilter.AsCimInstance(), options);
            return instances.Select(i => (EventConsumer)scope.Mapper.Create(scope, i));
        }
    }
}