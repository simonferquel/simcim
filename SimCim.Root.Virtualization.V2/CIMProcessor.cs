using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMProcessor : CIMLogicalDevice
    {
        protected CIMProcessor()
        {
        }

        protected CIMProcessor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AddressWidth
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AddressWidth", out result);
                return result;
            }

            set
            {
                this.SetProperty("AddressWidth", value);
            }
        }

        public System.UInt16? CPUStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CPUStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("CPUStatus", value);
            }
        }

        public System.UInt32? CurrentClockSpeed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentClockSpeed", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentClockSpeed", value);
            }
        }

        public System.UInt16? DataWidth
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DataWidth", out result);
                return result;
            }

            set
            {
                this.SetProperty("DataWidth", value);
            }
        }

        public System.UInt32? ExternalBusClockSpeed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExternalBusClockSpeed", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExternalBusClockSpeed", value);
            }
        }

        public System.UInt16? Family
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Family", out result);
                return result;
            }

            set
            {
                this.SetProperty("Family", value);
            }
        }

        public System.UInt16? LoadPercentage
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LoadPercentage", out result);
                return result;
            }

            set
            {
                this.SetProperty("LoadPercentage", value);
            }
        }

        public System.UInt32? MaxClockSpeed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxClockSpeed", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxClockSpeed", value);
            }
        }

        public System.String OtherFamilyDescription
        {
            get
            {
                System.String result;
                this.GetProperty("OtherFamilyDescription", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherFamilyDescription", value);
            }
        }

        public System.String Role
        {
            get
            {
                System.String result;
                this.GetProperty("Role", out result);
                return result;
            }

            set
            {
                this.SetProperty("Role", value);
            }
        }

        public System.String Stepping
        {
            get
            {
                System.String result;
                this.GetProperty("Stepping", out result);
                return result;
            }

            set
            {
                this.SetProperty("Stepping", value);
            }
        }

        public System.String UniqueID
        {
            get
            {
                System.String result;
                this.GetProperty("UniqueID", out result);
                return result;
            }

            set
            {
                this.SetProperty("UniqueID", value);
            }
        }

        public System.UInt16? UpgradeMethod
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("UpgradeMethod", out result);
                return result;
            }

            set
            {
                this.SetProperty("UpgradeMethod", value);
            }
        }
    }
}