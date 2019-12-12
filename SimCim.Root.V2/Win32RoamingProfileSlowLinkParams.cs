using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32RoamingProfileSlowLinkParams : GenericInfrastructureObject
    {
        public Win32RoamingProfileSlowLinkParams()
        {
        }

        public Win32RoamingProfileSlowLinkParams(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ConnectionTransferRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectionTransferRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectionTransferRate", value);
            }
        }

        public System.UInt16? TimeOut
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TimeOut", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimeOut", value);
            }
        }
    }
}