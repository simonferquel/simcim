using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32MemoryDevice : Win32SMBIOSMemory
    {
        public Win32MemoryDevice()
        {
        }

        public Win32MemoryDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? ErrorGranularity
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ErrorGranularity", out result);
                return result;
            }
        }

        public Win32MemoryArray ResolveWin32MemoryDeviceArrayGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_MemoryDeviceArray", "Win32_MemoryArray", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32MemoryArray)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32PhysicalMemory ResolveWin32MemoryDeviceLocationAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_MemoryDeviceLocation", "Win32_PhysicalMemory", "Dependent", "Antecedent");
            return instances.Select(i => (Win32PhysicalMemory)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}