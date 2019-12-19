using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32CIMLogicalDeviceCIMDataFileAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_CIMLogicalDeviceCIMDataFile", "CIM_LogicalDevice", "CIM_DataFile", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32CIMLogicalDeviceCIMDataFileAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMDataFile> Dependent(CIMLogicalDevice inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMDataFile)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMLogicalDevice> Antecedent(CIMDataFile inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMDataFile> DependentAsync(CIMLogicalDevice inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMDataFile)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMLogicalDevice> AntecedentAsync(CIMDataFile inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (CIMLogicalDevice)scope.Mapper.Create(scope, i));
        }
    }
}