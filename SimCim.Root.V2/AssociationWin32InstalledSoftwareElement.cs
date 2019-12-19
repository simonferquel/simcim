using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32InstalledSoftwareElementAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_InstalledSoftwareElement", "Win32_SoftwareElement", "CIM_ComputerSystem", "Software", "System");
        private IInfrastructureObjectScope _scope;
        public Win32InstalledSoftwareElementAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMComputerSystem> System(Win32SoftwareElement inSoftware, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inSoftware.AsCimInstance(), options);
            return instances.Select(i => (CIMComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32SoftwareElement> Software(CIMComputerSystem inSystem, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSystem.AsCimInstance(), options);
            return instances.Select(i => (Win32SoftwareElement)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMComputerSystem> SystemAsync(Win32SoftwareElement inSoftware, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inSoftware.AsCimInstance(), options);
            return instances.Select(i => (CIMComputerSystem)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32SoftwareElement> SoftwareAsync(CIMComputerSystem inSystem, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSystem.AsCimInstance(), options);
            return instances.Select(i => (Win32SoftwareElement)scope.Mapper.Create(scope, i));
        }
    }
}