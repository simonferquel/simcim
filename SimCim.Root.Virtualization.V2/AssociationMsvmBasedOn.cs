﻿using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.Virtualization.V2
{
    public struct MsvmBasedOnAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Msvm_BasedOn", "CIM_StorageExtent", "CIM_StorageExtent", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MsvmBasedOnAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMStorageExtent> Dependent(CIMStorageExtent inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMStorageExtent)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMStorageExtent> Antecedent(CIMStorageExtent inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMStorageExtent)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMStorageExtent> DependentAsync(CIMStorageExtent inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMStorageExtent)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMStorageExtent> AntecedentAsync(CIMStorageExtent inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMStorageExtent)scope.Mapper.Create(scope, i));
        }
    }
}