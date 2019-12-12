using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32CommandLineAccess : CIMServiceAccessPoint
    {
        public Win32CommandLineAccess()
        {
        }

        public Win32CommandLineAccess(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CommandLine
        {
            get
            {
                System.String result;
                this.GetProperty("CommandLine", out result);
                return result;
            }
        }

        public Win32ApplicationService ResolveWin32ApplicationCommandLineAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ApplicationCommandLine", "Win32_ApplicationService", "Dependent", "Antecedent");
            return instances.Select(i => (Win32ApplicationService)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32ShortcutAction ResolveWin32ShortcutSAPAction()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ShortcutSAP", "Win32_ShortcutAction", "Element", "Action");
            return instances.Select(i => (Win32ShortcutAction)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}