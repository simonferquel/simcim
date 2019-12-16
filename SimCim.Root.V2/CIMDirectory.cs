using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMDirectory : CIMLogicalFile
    {
        protected CIMDirectory()
        {
        }

        protected CIMDirectory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32Share ResolveWin32ShareToDirectoryShare()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ShareToDirectory", "Win32_Share", "SharedElement", "Share");
            return instances.Select(i => (Win32Share)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<CIMDataFile> ResolveCIMDirectoryContainsFilePartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "CIM_DirectoryContainsFile", "CIM_DataFile", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMDataFile)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}