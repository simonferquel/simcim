using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct CIMDirectoryContainsFileAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("CIM_DirectoryContainsFile", "CIM_Directory", "CIM_DataFile", "GroupComponent", "PartComponent");
        private IInfrastructureObjectScope _scope;
        public CIMDirectoryContainsFileAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMDataFile> PartComponent(CIMDirectory inGroupComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inGroupComponent.AsCimInstance());
            return instances.Select(i => (CIMDataFile)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<CIMDirectory> GroupComponent(CIMDataFile inPartComponent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inPartComponent.AsCimInstance());
            return instances.Select(i => (CIMDirectory)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMDataFile> PartComponentAsync(CIMDirectory inGroupComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inGroupComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMDataFile)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMDirectory> GroupComponentAsync(CIMDataFile inPartComponent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inPartComponent.AsCimInstance(), options);
            return instances.Select(i => (CIMDirectory)scope.Mapper.Create(scope, i));
        }
    }
}