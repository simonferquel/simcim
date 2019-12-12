using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMTapeDrive : CIMMediaAccessDevice
    {
        protected CIMTapeDrive()
        {
        }

        protected CIMTapeDrive(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? EOTWarningZoneSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EOTWarningZoneSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("EOTWarningZoneSize", value);
            }
        }

        public System.UInt32? MaxPartitionCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxPartitionCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxPartitionCount", value);
            }
        }

        public System.UInt64? MaxRewindTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxRewindTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxRewindTime", value);
            }
        }

        public System.UInt32? Padding
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Padding", out result);
                return result;
            }

            set
            {
                this.SetProperty("Padding", value);
            }
        }
    }
}