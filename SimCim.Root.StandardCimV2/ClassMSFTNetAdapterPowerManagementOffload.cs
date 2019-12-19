using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterPowerManagementOffload : GenericInfrastructureObject
    {
        public MSFTNetAdapterPowerManagementOffload()
        {
        }

        public MSFTNetAdapterPowerManagementOffload(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.UInt32? OffloadType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OffloadType", out result);
                return result;
            }

            set
            {
                this.SetProperty("OffloadType", value);
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
    }
}