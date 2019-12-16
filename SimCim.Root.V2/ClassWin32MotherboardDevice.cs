using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32MotherboardDevice : CIMLogicalDevice
    {
        public Win32MotherboardDevice()
        {
        }

        public Win32MotherboardDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String PrimaryBusType
        {
            get
            {
                System.String result;
                this.GetProperty("PrimaryBusType", out result);
                return result;
            }
        }

        public System.String RevisionNumber
        {
            get
            {
                System.String result;
                this.GetProperty("RevisionNumber", out result);
                return result;
            }
        }

        public System.String SecondaryBusType
        {
            get
            {
                System.String result;
                this.GetProperty("SecondaryBusType", out result);
                return result;
            }
        }
    }
}