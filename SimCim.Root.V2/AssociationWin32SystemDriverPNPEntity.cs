using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SystemDriverPNPEntityAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SystemDriverPNPEntity", "Win32_PNPEntity", "Win32_SystemDriver", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32SystemDriverPNPEntityAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32SystemDriver> Dependent(CimInstance inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent, options);
            return instances.Select(i => (Win32SystemDriver)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CimInstance> Antecedent(Win32SystemDriver inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances;
        }

        public IObservable<Win32SystemDriver> DependentAsync(CimInstance inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent, options);
            return instances.Select(i => (Win32SystemDriver)scope.Mapper.Create(scope, i));
        }

        public IObservable<CimInstance> AntecedentAsync(Win32SystemDriver inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances;
        }
    }
}