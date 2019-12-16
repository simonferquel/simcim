using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32PrinterShareAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_PrinterShare", "Win32_Printer", "Win32_Share", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32PrinterShareAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Share> Dependent(Win32Printer inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (Win32Share)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32Printer> Antecedent(Win32Share inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (Win32Printer)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Share> DependentAsync(Win32Printer inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32Share)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Printer> AntecedentAsync(Win32Share inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32Printer)scope.Mapper.Create(scope, i));
        }
    }
}