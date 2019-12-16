using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterSriovVfSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterSriovVfSettingData()
        {
        }

        public MSFTNetAdapterSriovVfSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CurrentMacAddress
        {
            get
            {
                System.String result;
                this.GetProperty("CurrentMacAddress", out result);
                return result;
            }
        }

        public System.UInt16? FunctionID
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("FunctionID", out result);
                return result;
            }
        }

        public System.String PermanentMacAddress
        {
            get
            {
                System.String result;
                this.GetProperty("PermanentMacAddress", out result);
                return result;
            }
        }

        public System.UInt32? SwitchID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SwitchID", out result);
                return result;
            }
        }

        public System.String VmFriendlyName
        {
            get
            {
                System.String result;
                this.GetProperty("VmFriendlyName", out result);
                return result;
            }
        }

        public System.String VmID
        {
            get
            {
                System.String result;
                this.GetProperty("VmID", out result);
                return result;
            }
        }

        public System.String VmNicID
        {
            get
            {
                System.String result;
                this.GetProperty("VmNicID", out result);
                return result;
            }
        }

        public System.UInt32[] VPortID
        {
            get
            {
                System.UInt32[] result;
                this.GetProperty("VPortID", out result);
                return result;
            }
        }
    }
}