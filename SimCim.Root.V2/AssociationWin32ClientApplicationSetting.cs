using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.V2
{
    public struct Win32ClientApplicationSettingAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("Win32_ClientApplicationSetting", "Win32_DCOMApplication", "CIM_DataFile", "Application", "Client");
        private IInfrastructureObjectScope _scope;
        public Win32ClientApplicationSettingAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<CIMDataFile> Client(Win32DCOMApplication inApplication)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inApplication.AsCimInstance());
            return instances.Select(i => (CIMDataFile)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<Win32DCOMApplication> Application(CIMDataFile inClient)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inClient.AsCimInstance());
            return instances.Select(i => (Win32DCOMApplication)scope.Mapper.Create(scope, i));
        }

        public IObservable<CIMDataFile> ClientAsync(Win32DCOMApplication inApplication, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inApplication.AsCimInstance(), options);
            return instances.Select(i => (CIMDataFile)scope.Mapper.Create(scope, i));
        }

        public IObservable<Win32DCOMApplication> ApplicationAsync(CIMDataFile inClient, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inClient.AsCimInstance(), options);
            return instances.Select(i => (Win32DCOMApplication)scope.Mapper.Create(scope, i));
        }
    }
}