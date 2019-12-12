using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMVLANEndpointSettingData : CIMSettingData
    {
        protected CIMVLANEndpointSettingData()
        {
        }

        protected CIMVLANEndpointSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AccessVLAN
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AccessVLAN", out result);
                return result;
            }

            set
            {
                this.SetProperty("AccessVLAN", value);
            }
        }

        public System.UInt16? DefaultVLAN
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DefaultVLAN", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefaultVLAN", value);
            }
        }

        public System.UInt16? NativeVLAN
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NativeVLAN", out result);
                return result;
            }

            set
            {
                this.SetProperty("NativeVLAN", value);
            }
        }

        public System.UInt16[] PruneEligibleVLANList
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("PruneEligibleVLANList", out result);
                return result;
            }

            set
            {
                this.SetProperty("PruneEligibleVLANList", value);
            }
        }

        public System.UInt16[] TrunkedVLANList
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("TrunkedVLANList", out result);
                return result;
            }

            set
            {
                this.SetProperty("TrunkedVLANList", value);
            }
        }
    }
}