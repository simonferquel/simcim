using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32PnPDeviceProperty : GenericInfrastructureObject
    {
        protected Win32PnPDeviceProperty()
        {
        }

        protected Win32PnPDeviceProperty(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DeviceID
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceID", out result);
                return result;
            }
        }

        public System.String Key
        {
            get
            {
                System.String result;
                this.GetProperty("key", out result);
                return result;
            }
        }

        public System.String KeyName
        {
            get
            {
                System.String result;
                this.GetProperty("KeyName", out result);
                return result;
            }
        }

        public System.UInt32? Type
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Type", out result);
                return result;
            }
        }
    }
}