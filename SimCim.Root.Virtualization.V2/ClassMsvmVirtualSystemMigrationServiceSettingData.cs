using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualSystemMigrationServiceSettingData : CIMSettingData
    {
        public MsvmVirtualSystemMigrationServiceSettingData()
        {
        }

        public MsvmVirtualSystemMigrationServiceSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AuthenticationType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AuthenticationType", out result);
                return result;
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

        public System.Boolean? EnableSmbTransport
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableSmbTransport", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnableSmbTransport", value);
            }
        }

        public System.Boolean? EnableVirtualSystemMigration
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableVirtualSystemMigration", out result);
                return result;
            }
        }

        public System.UInt32? MaximumActiveStorageMigration
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumActiveStorageMigration", out result);
                return result;
            }
        }

        public System.UInt32? MaximumActiveVirtualSystemMigration
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumActiveVirtualSystemMigration", out result);
                return result;
            }
        }
    }
}