using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PhysicalMemory : CIMPhysicalMemory
    {
        public Win32PhysicalMemory()
        {
        }

        public Win32PhysicalMemory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Attributes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Attributes", out result);
                return result;
            }
        }

        public System.UInt32? ConfiguredClockSpeed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConfiguredClockSpeed", out result);
                return result;
            }
        }

        public System.UInt32? ConfiguredVoltage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConfiguredVoltage", out result);
                return result;
            }
        }

        public System.String DeviceLocator
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceLocator", out result);
                return result;
            }
        }

        public System.UInt16? InterleaveDataDepth
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("InterleaveDataDepth", out result);
                return result;
            }
        }

        public System.UInt32? MaxVoltage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxVoltage", out result);
                return result;
            }
        }

        public System.UInt32? MinVoltage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MinVoltage", out result);
                return result;
            }
        }

        public System.UInt32? SMBIOSMemoryType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SMBIOSMemoryType", out result);
                return result;
            }
        }

        public System.UInt16? TypeDetail
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TypeDetail", out result);
                return result;
            }
        }

        public Win32MemoryDevice ResolveWin32MemoryDeviceLocationDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_MemoryDeviceLocation", "Win32_MemoryDevice", "Antecedent", "Dependent");
            return instances.Select(i => (Win32MemoryDevice)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<Win32PhysicalMemoryArray> ResolveWin32PhysicalMemoryLocationGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_PhysicalMemoryLocation", "Win32_PhysicalMemoryArray", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32PhysicalMemoryArray)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}