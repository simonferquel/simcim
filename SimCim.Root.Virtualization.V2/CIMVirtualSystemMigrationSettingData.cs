using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMVirtualSystemMigrationSettingData : CIMSettingData
    {
        protected CIMVirtualSystemMigrationSettingData()
        {
        }

        protected CIMVirtualSystemMigrationSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Bandwidth
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Bandwidth", out result);
                return result;
            }

            set
            {
                this.SetProperty("Bandwidth", value);
            }
        }

        public System.String BandwidthUnit
        {
            get
            {
                System.String result;
                this.GetProperty("BandwidthUnit", out result);
                return result;
            }

            set
            {
                this.SetProperty("BandwidthUnit", value);
            }
        }

        public System.UInt16? MigrationType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MigrationType", out result);
                return result;
            }

            set
            {
                this.SetProperty("MigrationType", value);
            }
        }

        public System.String OtherTransportType
        {
            get
            {
                System.String result;
                this.GetProperty("OtherTransportType", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherTransportType", value);
            }
        }

        public System.UInt16? Priority
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Priority", out result);
                return result;
            }

            set
            {
                this.SetProperty("Priority", value);
            }
        }

        public System.UInt16? TransportType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TransportType", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransportType", value);
            }
        }
    }
}