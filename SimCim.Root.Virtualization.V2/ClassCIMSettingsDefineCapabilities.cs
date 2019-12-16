using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMSettingsDefineCapabilities : CIMComponent
    {
        protected CIMSettingsDefineCapabilities()
        {
        }

        protected CIMSettingsDefineCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMCapabilities GroupComponent
        {
            get
            {
                CIMCapabilities result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupComponent", value);
            }
        }

        public new CIMSettingData PartComponent
        {
            get
            {
                CIMSettingData result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("PartComponent", value);
            }
        }

        public System.UInt16? PropertyPolicy
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PropertyPolicy", out result);
                return result;
            }

            set
            {
                this.SetProperty("PropertyPolicy", value);
            }
        }

        public System.UInt16? ValueRange
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ValueRange", out result);
                return result;
            }

            set
            {
                this.SetProperty("ValueRange", value);
            }
        }

        public System.UInt16? ValueRole
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ValueRole", out result);
                return result;
            }

            set
            {
                this.SetProperty("ValueRole", value);
            }
        }
    }
}