using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PortableBattery : CIMBattery
    {
        public Win32PortableBattery()
        {
        }

        public Win32PortableBattery(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? CapacityMultiplier
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CapacityMultiplier", out result);
                return result;
            }
        }

        public System.String Location
        {
            get
            {
                System.String result;
                this.GetProperty("Location", out result);
                return result;
            }
        }

        public System.String ManufactureDate
        {
            get
            {
                System.String result;
                this.GetProperty("ManufactureDate", out result);
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

        public System.UInt16? MaxBatteryError
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MaxBatteryError", out result);
                return result;
            }
        }
    }
}