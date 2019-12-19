using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32PrinterControllerAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_PrinterController", "CIM_Controller", "Win32_Printer", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32PrinterControllerAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Printer> Dependent(CIMController inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32Printer)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMController> Antecedent(Win32Printer inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMController)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Printer> DependentAsync(CIMController inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32Printer)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMController> AntecedentAsync(Win32Printer inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMController)scope.Mapper.Create(scope, i));
        }
    }
}