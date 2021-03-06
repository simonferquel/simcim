﻿using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmFcActiveConnectionAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_FcActiveConnection", "Msvm_FcEndpoint", "Msvm_FcEndpoint", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmFcActiveConnectionAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MsvmFcEndpoint> Dependent(MsvmFcEndpoint inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmFcEndpoint)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MsvmFcEndpoint> Antecedent(MsvmFcEndpoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmFcEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmFcEndpoint> DependentAsync(MsvmFcEndpoint inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MsvmFcEndpoint)scope.Mapper.Create(scope, i));
        }

        public IObservable<MsvmFcEndpoint> AntecedentAsync(MsvmFcEndpoint inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MsvmFcEndpoint)scope.Mapper.Create(scope, i));
        }
    }
}