using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Directory : CIMDirectory
    {
        public Win32Directory()
        {
        }

        public Win32Directory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32Volume ResolveWin32MountPointVolume()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_MountPoint", "Win32_Volume", "Directory", "Volume");
            return instances.Select(i => (Win32Volume)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<Win32LogicalDisk> ResolveWin32LogicalDiskRootDirectoryGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalDiskRootDirectory", "Win32_LogicalDisk", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32LogicalDisk)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<Win32Directory> ResolveWin32SubDirectoryPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SubDirectory", "Win32_Directory", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32Directory)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<Win32Directory> ResolveWin32SubDirectoryGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SubDirectory", "Win32_Directory", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32Directory)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public Win32LogicalProgramGroup ResolveWin32LogicalProgramGroupDirectoryAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalProgramGroupDirectory", "Win32_LogicalProgramGroup", "Dependent", "Antecedent");
            return instances.Select(i => (Win32LogicalProgramGroup)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}