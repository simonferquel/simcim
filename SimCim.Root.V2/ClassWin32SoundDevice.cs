using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SoundDevice : CIMLogicalDevice
    {
        public Win32SoundDevice()
        {
        }

        public Win32SoundDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? DMABufferSize
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DMABufferSize", out result);
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

        public System.UInt32? MPU401Address
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MPU401Address", out result);
                return result;
            }
        }

        public System.String ProductName
        {
            get
            {
                System.String result;
                this.GetProperty("ProductName", out result);
                return result;
            }
        }
    }
}