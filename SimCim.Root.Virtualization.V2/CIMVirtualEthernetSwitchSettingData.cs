using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMVirtualEthernetSwitchSettingData : CIMVirtualSystemSettingData
    {
        protected CIMVirtualEthernetSwitchSettingData()
        {
        }

        protected CIMVirtualEthernetSwitchSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] AssociatedResourcePool
        {
            get
            {
                System.String[] result;
                this.GetProperty("AssociatedResourcePool", out result);
                return result;
            }

            set
            {
                this.SetProperty("AssociatedResourcePool", value);
            }
        }

        public System.UInt32? MaxNumMACAddress
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxNumMACAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxNumMACAddress", value);
            }
        }

        public System.String[] VLANConnection
        {
            get
            {
                System.String[] result;
                this.GetProperty("VLANConnection", out result);
                return result;
            }

            set
            {
                this.SetProperty("VLANConnection", value);
            }
        }
    }
}