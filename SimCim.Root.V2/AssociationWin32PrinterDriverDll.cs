using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32PrinterDriverDllAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_PrinterDriverDll", "CIM_DataFile", "Win32_Printer", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32PrinterDriverDllAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Printer> Dependent(CIMDataFile inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (Win32Printer)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMDataFile> Antecedent(Win32Printer inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (CIMDataFile)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Printer> DependentAsync(CIMDataFile inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32Printer)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMDataFile> AntecedentAsync(Win32Printer inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMDataFile)scope.Mapper.Create(scope, i));
        }
    }
}