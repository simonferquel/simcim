﻿using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32SessionProcessAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_SessionProcess", "Win32_LogonSession", "Win32_Process", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public Win32SessionProcessAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<Win32Process> Dependent(Win32LogonSession inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32Process)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32LogonSession> Antecedent(Win32Process inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32LogonSession)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32Process> DependentAsync(Win32LogonSession inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (Win32Process)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32LogonSession> AntecedentAsync(Win32Process inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (Win32LogonSession)scope.Mapper.Create(scope, i));
        }
    }
}