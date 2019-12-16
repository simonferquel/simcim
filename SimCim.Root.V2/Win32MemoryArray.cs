using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32MemoryArray : Win32SMBIOSMemory
    {
        public Win32MemoryArray()
        {
        }

        public Win32MemoryArray(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public Win32PhysicalMemoryArray ResolveWin32MemoryArrayLocationAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_MemoryArrayLocation", "Win32_PhysicalMemoryArray", "Dependent", "Antecedent");
            return instances.Select(i => (Win32PhysicalMemoryArray)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<Win32MemoryDevice> ResolveWin32MemoryDeviceArrayPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_MemoryDeviceArray", "Win32_MemoryDevice", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32MemoryDevice)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}