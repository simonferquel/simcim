using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchPortRoutingDomainSettingData : MsvmEthernetSwitchPortFeatureSettingData
    {
        public MsvmEthernetSwitchPortRoutingDomainSettingData()
        {
        }

        public MsvmEthernetSwitchPortRoutingDomainSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32[] IsolationIdList
        {
            get
            {
                System.UInt32[] result;
                this.GetProperty("IsolationIdList", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsolationIdList", value);
            }
        }

        public System.String[] IsolationIdNameList
        {
            get
            {
                System.String[] result;
                this.GetProperty("IsolationIdNameList", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsolationIdNameList", value);
            }
        }

        public System.String RoutingDomainGuid
        {
            get
            {
                System.String result;
                this.GetProperty("RoutingDomainGuid", out result);
                return result;
            }

            set
            {
                this.SetProperty("RoutingDomainGuid", value);
            }
        }

        public System.String RoutingDomainName
        {
            get
            {
                System.String result;
                this.GetProperty("RoutingDomainName", out result);
                return result;
            }

            set
            {
                this.SetProperty("RoutingDomainName", value);
            }
        }
    }
}