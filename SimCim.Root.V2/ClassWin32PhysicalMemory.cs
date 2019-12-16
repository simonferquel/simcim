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
    }
}