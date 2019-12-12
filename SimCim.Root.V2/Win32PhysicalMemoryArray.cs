using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PhysicalMemoryArray : CIMPhysicalPackage
    {
        public Win32PhysicalMemoryArray()
        {
        }

        public Win32PhysicalMemoryArray(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Location
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Location", out result);
                return result;
            }
        }

        public System.UInt32? MaxCapacity
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxCapacity", out result);
                return result;
            }
        }

        public System.UInt64? MaxCapacityEx
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxCapacityEx", out result);
                return result;
            }
        }

        public System.UInt16? MemoryDevices
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MemoryDevices", out result);
                return result;
            }
        }

        public System.UInt16? MemoryErrorCorrection
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MemoryErrorCorrection", out result);
                return result;
            }
        }

        public System.UInt16? Use
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Use", out result);
                return result;
            }
        }

        public IEnumerable<Win32PhysicalMemory> ResolveWin32PhysicalMemoryLocationPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_PhysicalMemoryLocation", "Win32_PhysicalMemory", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32PhysicalMemory)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public Win32MemoryArray ResolveWin32MemoryArrayLocationDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_MemoryArrayLocation", "Win32_MemoryArray", "Antecedent", "Dependent");
            return instances.Select(i => (Win32MemoryArray)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}