using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualHardDiskSettingData : CIMSettingData
    {
        public MsvmVirtualHardDiskSettingData()
        {
        }

        public MsvmVirtualHardDiskSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BlockSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BlockSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("BlockSize", value);
            }
        }

        public System.UInt64? DataAlignment
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DataAlignment", out result);
                return result;
            }

            set
            {
                this.SetProperty("DataAlignment", value);
            }
        }

        public System.UInt16? Format
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Format", out result);
                return result;
            }

            set
            {
                this.SetProperty("Format", value);
            }
        }

        public System.Boolean? IsPmemCompatible
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsPmemCompatible", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsPmemCompatible", value);
            }
        }

        public System.UInt32? LogicalSectorSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogicalSectorSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogicalSectorSize", value);
            }
        }

        public System.UInt64? MaxInternalSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxInternalSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxInternalSize", value);
            }
        }

        public System.String ParentIdentifier
        {
            get
            {
                System.String result;
                this.GetProperty("ParentIdentifier", out result);
                return result;
            }
        }

        public System.String ParentPath
        {
            get
            {
                System.String result;
                this.GetProperty("ParentPath", out result);
                return result;
            }

            set
            {
                this.SetProperty("ParentPath", value);
            }
        }

        public System.DateTime? ParentTimestamp
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("ParentTimestamp", out result);
                return result;
            }
        }

        public System.String Path
        {
            get
            {
                System.String result;
                this.GetProperty("Path", out result);
                return result;
            }

            set
            {
                this.SetProperty("Path", value);
            }
        }

        public System.UInt32? PhysicalSectorSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PhysicalSectorSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("PhysicalSectorSize", value);
            }
        }

        public System.UInt16? PmemAddressAbstractionType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PmemAddressAbstractionType", out result);
                return result;
            }

            set
            {
                this.SetProperty("PmemAddressAbstractionType", value);
            }
        }

        public System.UInt16? Type
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Type", out result);
                return result;
            }

            set
            {
                this.SetProperty("Type", value);
            }
        }

        public System.String VirtualDiskId
        {
            get
            {
                System.String result;
                this.GetProperty("VirtualDiskId", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualDiskId", value);
            }
        }
    }
}