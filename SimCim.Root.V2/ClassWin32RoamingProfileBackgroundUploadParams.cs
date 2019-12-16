using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32RoamingProfileBackgroundUploadParams : GenericInfrastructureObject
    {
        public Win32RoamingProfileBackgroundUploadParams()
        {
        }

        public Win32RoamingProfileBackgroundUploadParams(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Interval
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Interval", out result);
                return result;
            }

            set
            {
                this.SetProperty("Interval", value);
            }
        }

        public System.Byte? SchedulingMethod
        {
            get
            {
                System.Byte? result;
                this.GetProperty("SchedulingMethod", out result);
                return result;
            }

            set
            {
                this.SetProperty("SchedulingMethod", value);
            }
        }

        public System.UInt16? Time
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Time", out result);
                return result;
            }

            set
            {
                this.SetProperty("Time", value);
            }
        }
    }
}