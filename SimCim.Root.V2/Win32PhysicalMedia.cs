using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PhysicalMedia : CIMPhysicalMedia
    {
        public Win32PhysicalMedia()
        {
        }

        public Win32PhysicalMedia(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32DiskDrive ResolveWin32DiskDrivePhysicalMediaDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_DiskDrivePhysicalMedia", "Win32_DiskDrive", "Antecedent", "Dependent");
            return instances.Select(i => (Win32DiskDrive)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}