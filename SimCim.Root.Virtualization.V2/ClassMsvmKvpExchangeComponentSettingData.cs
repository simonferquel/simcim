using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmKvpExchangeComponentSettingData : CIMResourceAllocationSettingData
    {
        public MsvmKvpExchangeComponentSettingData()
        {
        }

        public MsvmKvpExchangeComponentSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? DisableHostKVPItems
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DisableHostKVPItems", out result);
                return result;
            }

            set
            {
                this.SetProperty("DisableHostKVPItems", value);
            }
        }

        public System.UInt16? EnabledState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EnabledState", out result);
                return result;
            }
        }

        public System.String[] HostExchangeItems
        {
            get
            {
                System.String[] result;
                this.GetProperty("HostExchangeItems", out result);
                return result;
            }
        }

        public System.String[] HostOnlyItems
        {
            get
            {
                System.String[] result;
                this.GetProperty("HostOnlyItems", out result);
                return result;
            }
        }
    }
}