using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32LogicalProgramGroupDirectoryAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_LogicalProgramGroupDirectory", "Win32_LogicalProgramGroup", "Win32_Directory", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32LogicalProgramGroupDirectoryAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Directory> Dependent(Win32LogicalProgramGroup inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32Directory)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32LogicalProgramGroup> Antecedent(Win32Directory inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32LogicalProgramGroup)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Directory> DependentAsync(Win32LogicalProgramGroup inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32Directory)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32LogicalProgramGroup> AntecedentAsync(Win32Directory inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32LogicalProgramGroup)scope.Mapper.Create(scope, i));
        }
    }
}