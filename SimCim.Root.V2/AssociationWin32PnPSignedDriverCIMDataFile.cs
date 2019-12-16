using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32PnPSignedDriverCIMDataFileAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_PnPSignedDriverCIMDataFile", "Win32_PnPSignedDriver", "CIM_DataFile", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32PnPSignedDriverCIMDataFileAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMDataFile> Dependent(Win32PnPSignedDriver inAntecedent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance());
            return instances.Select(i => (CIMDataFile)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32PnPSignedDriver> Antecedent(CIMDataFile inDependent)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance());
            return instances.Select(i => (Win32PnPSignedDriver)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMDataFile> DependentAsync(Win32PnPSignedDriver inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (CIMDataFile)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32PnPSignedDriver> AntecedentAsync(CIMDataFile inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32PnPSignedDriver)scope.Mapper.Create(scope, i));
        }
    }
}