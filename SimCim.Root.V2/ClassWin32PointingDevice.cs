using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PointingDevice : CIMPointingDevice
    {
        public Win32PointingDevice()
        {
        }

        public Win32PointingDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? DeviceInterface
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DeviceInterface", out result);
                return result;
            }
        }

        public System.UInt32? DoubleSpeedThreshold
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DoubleSpeedThreshold", out result);
                return result;
            }
        }

        public System.String HardwareType
        {
            get
            {
                System.String result;
                this.GetProperty("HardwareType", out result);
                return result;
            }
        }

        public System.String InfFileName
        {
            get
            {
                System.String result;
                this.GetProperty("InfFileName", out result);
                return result;
            }
        }

        public System.String InfSection
        {
            get
            {
                System.String result;
                this.GetProperty("InfSection", out result);
                return result;
            }
        }

        public System.String Manufacturer
        {
            get
            {
                System.String result;
                this.GetProperty("Manufacturer", out result);
                return result;
            }
        }

        public System.UInt32? QuadSpeedThreshold
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QuadSpeedThreshold", out result);
                return result;
            }
        }

        public System.UInt32? SampleRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SampleRate", out result);
                return result;
            }
        }

        public System.UInt32? Synch
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Synch", out result);
                return result;
            }
        }
    }
}