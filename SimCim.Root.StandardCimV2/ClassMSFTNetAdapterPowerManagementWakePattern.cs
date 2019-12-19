using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterPowerManagementWakePattern : GenericInfrastructureObject
    {
        public MSFTNetAdapterPowerManagementWakePattern()
        {
        }

        public MSFTNetAdapterPowerManagementWakePattern(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String FriendlyName
        {
            get
            {
                System.String result;
                this.GetProperty("FriendlyName", out result);
                return result;
            }

            set
            {
                this.SetProperty("FriendlyName", value);
            }
        }

        public System.UInt32? ID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ID", out result);
                return result;
            }

            set
            {
                this.SetProperty("ID", value);
            }
        }

        public System.UInt32? Priority
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Priority", out result);
                return result;
            }

            set
            {
                this.SetProperty("Priority", value);
            }
        }

        public System.UInt32? WakePacketType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WakePacketType", out result);
                return result;
            }

            set
            {
                this.SetProperty("WakePacketType", value);
            }
        }
    }
}