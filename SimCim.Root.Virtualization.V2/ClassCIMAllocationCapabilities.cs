using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMAllocationCapabilities : CIMCapabilities
    {
        protected CIMAllocationCapabilities()
        {
        }

        protected CIMAllocationCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.UInt16? RequestTypesSupported
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("RequestTypesSupported", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestTypesSupported", value);
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

        public System.UInt16? SharingMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SharingMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("SharingMode", value);
            }
        }

        public System.UInt16[] SupportedAddStates
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("SupportedAddStates", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportedAddStates", value);
            }
        }

        public System.UInt16[] SupportedRemoveStates
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("SupportedRemoveStates", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportedRemoveStates", value);
            }
        }
    }
}