using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct CIMProcessExecutableAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("CIM_ProcessExecutable", "CIM_DataFile", "CIM_Process", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public CIMProcessExecutableAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMProcess> Dependent(CIMDataFile inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMProcess)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMDataFile> Antecedent(CIMProcess inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMDataFile)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMProcess> DependentAsync(CIMDataFile inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMProcess)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMDataFile> AntecedentAsync(CIMProcess inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMDataFile)scope.Mapper.Create(scope, i));
        }
    }
}