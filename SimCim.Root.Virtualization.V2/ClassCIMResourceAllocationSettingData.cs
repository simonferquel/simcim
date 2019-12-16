using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMResourceAllocationSettingData : CIMSettingData
    {
        protected CIMResourceAllocationSettingData()
        {
        }

        protected CIMResourceAllocationSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Address
        {
            get
            {
                System.String result;
                this.GetProperty("Address", out result);
                return result;
            }

            set
            {
                this.SetProperty("Address", value);
            }
        }

        public System.String AddressOnParent
        {
            get
            {
                System.String result;
                this.GetProperty("AddressOnParent", out result);
                return result;
            }

            set
            {
                this.SetProperty("AddressOnParent", value);
            }
        }

        public System.String AllocationUnits
        {
            get
            {
                System.String result;
                this.GetProperty("AllocationUnits", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllocationUnits", value);
            }
        }

        public System.Boolean? AutomaticAllocation
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AutomaticAllocation", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutomaticAllocation", value);
            }
        }

        public System.Boolean? AutomaticDeallocation
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AutomaticDeallocation", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutomaticDeallocation", value);
            }
        }

        public System.String[] Connection
        {
            get
            {
                System.String[] result;
                this.GetProperty("Connection", out result);
                return result;
            }

            set
            {
                this.SetProperty("Connection", value);
            }
        }

        public System.UInt16? ConsumerVisibility
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ConsumerVisibility", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConsumerVisibility", value);
            }
        }

        public System.String[] HostResource
        {
            get
            {
                System.String[] result;
                this.GetProperty("HostResource", out result);
                return result;
            }

            set
            {
                this.SetProperty("HostResource", value);
            }
        }

        public System.UInt64? Limit
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Limit", out result);
                return result;
            }

            set
            {
                this.SetProperty("Limit", value);
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

        public System.String Parent
        {
            get
            {
                System.String result;
                this.GetProperty("Parent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Parent", value);
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

        public System.UInt64? Reservation
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Reservation", out result);
                return result;
            }

            set
            {
                this.SetProperty("Reservation", value);
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

        public System.UInt64? VirtualQuantity
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualQuantity", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualQuantity", value);
            }
        }

        public System.String VirtualQuantityUnits
        {
            get
            {
                System.String result;
                this.GetProperty("VirtualQuantityUnits", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualQuantityUnits", value);
            }
        }

        public System.UInt32? Weight
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Weight", out result);
                return result;
            }

            set
            {
                this.SetProperty("Weight", value);
            }
        }
    }
}