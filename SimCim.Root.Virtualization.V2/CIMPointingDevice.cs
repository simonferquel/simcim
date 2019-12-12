using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMPointingDevice : CIMUserDevice
    {
        protected CIMPointingDevice()
        {
        }

        protected CIMPointingDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Handedness
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Handedness", out result);
                return result;
            }

            set
            {
                this.SetProperty("Handedness", value);
            }
        }

        public System.Byte? NumberOfButtons
        {
            get
            {
                System.Byte? result;
                this.GetProperty("NumberOfButtons", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfButtons", value);
            }
        }

        public System.UInt16? PointingType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PointingType", out result);
                return result;
            }

            set
            {
                this.SetProperty("PointingType", value);
            }
        }

        public System.UInt32? Resolution
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Resolution", out result);
                return result;
            }

            set
            {
                this.SetProperty("Resolution", value);
            }
        }
    }
}