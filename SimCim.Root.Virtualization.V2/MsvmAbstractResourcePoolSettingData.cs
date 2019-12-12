using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class MsvmAbstractResourcePoolSettingData : CIMSettingData
    {
        protected MsvmAbstractResourcePoolSettingData()
        {
        }

        protected MsvmAbstractResourcePoolSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? LoadBalancingBehavior
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LoadBalancingBehavior", out result);
                return result;
            }

            set
            {
                this.SetProperty("LoadBalancingBehavior", value);
            }
        }

        public System.UInt16? MappingBehavior
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MappingBehavior", out result);
                return result;
            }

            set
            {
                this.SetProperty("MappingBehavior", value);
            }
        }

        public System.String[] MappingOrder
        {
            get
            {
                System.String[] result;
                this.GetProperty("MappingOrder", out result);
                return result;
            }

            set
            {
                this.SetProperty("MappingOrder", value);
            }
        }

        public System.String Notes
        {
            get
            {
                System.String result;
                this.GetProperty("Notes", out result);
                return result;
            }

            set
            {
                this.SetProperty("Notes", value);
            }
        }

        public System.String OtherResourceType
        {
            get
            {
                System.String result;
                this.GetProperty("OtherResourceType", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherResourceType", value);
            }
        }

        public System.String PoolID
        {
            get
            {
                System.String result;
                this.GetProperty("PoolID", out result);
                return result;
            }

            set
            {
                this.SetProperty("PoolID", value);
            }
        }

        public System.String ResourceSubType
        {
            get
            {
                System.String result;
                this.GetProperty("ResourceSubType", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResourceSubType", value);
            }
        }

        public System.UInt16? ResourceType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ResourceType", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResourceType", value);
            }
        }
    }
}