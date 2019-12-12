using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualSystemMigrationSettingData : CIMVirtualSystemMigrationSettingData
    {
        public MsvmVirtualSystemMigrationSettingData()
        {
        }

        public MsvmVirtualSystemMigrationSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AllowOverwriteExistingFile
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AllowOverwriteExistingFile", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowOverwriteExistingFile", value);
            }
        }

        public System.Boolean? AvoidRemovingVHDs
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AvoidRemovingVHDs", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvoidRemovingVHDs", value);
            }
        }

        public System.Boolean? CancelIfBlackoutThresholdExceeded
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CancelIfBlackoutThresholdExceeded", out result);
                return result;
            }

            set
            {
                this.SetProperty("CancelIfBlackoutThresholdExceeded", value);
            }
        }

        public System.UInt16? CPUCappingMagnitude
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CPUCappingMagnitude", out result);
                return result;
            }

            set
            {
                this.SetProperty("CPUCappingMagnitude", value);
            }
        }

        public System.String[] DestinationIPAddressList
        {
            get
            {
                System.String[] result;
                this.GetProperty("DestinationIPAddressList", out result);
                return result;
            }

            set
            {
                this.SetProperty("DestinationIPAddressList", value);
            }
        }

        public System.String DestinationPlannedVirtualSystemId
        {
            get
            {
                System.String result;
                this.GetProperty("DestinationPlannedVirtualSystemId", out result);
                return result;
            }

            set
            {
                this.SetProperty("DestinationPlannedVirtualSystemId", value);
            }
        }

        public System.Boolean? EnableCompression
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableCompression", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnableCompression", value);
            }
        }

        public System.Boolean? EnableVhdCompression
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableVhdCompression", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnableVhdCompression", value);
            }
        }

        public System.Boolean? RemoveSourceUnmanagedVhds
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RemoveSourceUnmanagedVhds", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoveSourceUnmanagedVhds", value);
            }
        }

        public System.Boolean? RetainVhdCopiesOnSource
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RetainVhdCopiesOnSource", out result);
                return result;
            }

            set
            {
                this.SetProperty("RetainVhdCopiesOnSource", value);
            }
        }

        public System.String[] UnmanagedVhds
        {
            get
            {
                System.String[] result;
                this.GetProperty("UnmanagedVhds", out result);
                return result;
            }

            set
            {
                this.SetProperty("UnmanagedVhds", value);
            }
        }
    }
}