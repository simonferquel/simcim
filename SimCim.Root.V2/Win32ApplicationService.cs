using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ApplicationService : CIMService
    {
        public Win32ApplicationService()
        {
        }

        public Win32ApplicationService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32CommandLineAccess ResolveWin32ApplicationCommandLineDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ApplicationCommandLine", "Win32_CommandLineAccess", "Antecedent", "Dependent");
            return instances.Select(i => (Win32CommandLineAccess)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}