using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchPortIsolationSettingData : MsvmEthernetSwitchPortFeatureSettingData
    {
        public MsvmEthernetSwitchPortIsolationSettingData()
        {
        }

        public MsvmEthernetSwitchPortIsolationSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AllowUntaggedTraffic
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AllowUntaggedTraffic", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowUntaggedTraffic", value);
            }
        }

        public System.UInt32? DefaultIsolationId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DefaultIsolationId", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefaultIsolationId", value);
            }
        }

        public System.Boolean? EnableMultiTenantStack
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableMultiTenantStack", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnableMultiTenantStack", value);
            }
        }

        public System.UInt32? IsolationMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IsolationMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsolationMode", value);
            }
        }
    }
}