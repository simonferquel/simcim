using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ControllerHasHubAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ControllerHasHub", "Win32_USBController", "Win32_USBHub", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32ControllerHasHubAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32USBHub> Dependent(Win32USBController inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32USBHub)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32USBController> Antecedent(Win32USBHub inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32USBController)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32USBHub> DependentAsync(Win32USBController inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32USBHub)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32USBController> AntecedentAsync(Win32USBHub inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32USBController)scope.Mapper.Create(scope, i));
        }
    }
}