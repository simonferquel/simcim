using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32DriverForDeviceAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_DriverForDevice", "Win32_Printer", "Win32_PrinterDriver", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32DriverForDeviceAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32PrinterDriver> Dependent(Win32Printer inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (Win32PrinterDriver)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32Printer> Antecedent(Win32PrinterDriver inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (Win32Printer)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32PrinterDriver> DependentAsync(Win32Printer inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32PrinterDriver)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Printer> AntecedentAsync(Win32PrinterDriver inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32Printer)scope.Mapper.Create(scope, i));
        }
    }
}