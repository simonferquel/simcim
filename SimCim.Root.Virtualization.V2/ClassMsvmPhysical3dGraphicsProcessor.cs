using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmPhysical3dGraphicsProcessor : CIMLogicalDevice
    {
        public MsvmPhysical3dGraphicsProcessor()
        {
        }

        public MsvmPhysical3dGraphicsProcessor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AdapterIndexID
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AdapterIndexID", out result);
                return result;
            }
        }

        public System.UInt64? AvailableVideoMemory
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvailableVideoMemory", out result);
                return result;
            }
        }

        public System.Boolean? CompatibleForVirtualization
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CompatibleForVirtualization", out result);
                return result;
            }
        }

        public System.UInt64? DedicatedSystemMemory
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DedicatedSystemMemory", out result);
                return result;
            }
        }

        public System.UInt64? DedicatedVideoMemory
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DedicatedVideoMemory", out result);
                return result;
            }
        }

        public System.String DirectXVersion
        {
            get
            {
                System.String result;
                this.GetProperty("DirectXVersion", out result);
                return result;
            }
        }

        public System.DateTime? DriverDate
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("DriverDate", out result);
                return result;
            }
        }

        public System.DateTime? DriverInstalled
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("DriverInstalled", out result);
                return result;
            }
        }

        public System.String DriverModelVersion
        {
            get
            {
                System.String result;
                this.GetProperty("DriverModelVersion", out result);
                return result;
            }
        }

        public System.String DriverProvider
        {
            get
            {
                System.String result;
                this.GetProperty("DriverProvider", out result);
                return result;
            }
        }

        public System.String DriverVersion
        {
            get
            {
                System.String result;
                this.GetProperty("DriverVersion", out result);
                return result;
            }
        }

        public System.Boolean? EnabledForVirtualization
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnabledForVirtualization", out result);
                return result;
            }
        }

        public System.String GPUID
        {
            get
            {
                System.String result;
                this.GetProperty("GPUID", out result);
                return result;
            }
        }

        public System.String PixelShaderVersion
        {
            get
            {
                System.String result;
                this.GetProperty("PixelShaderVersion", out result);
                return result;
            }
        }

        public System.UInt64? Rating
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Rating", out result);
                return result;
            }
        }

        public System.UInt64? SharedSystemMemory
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SharedSystemMemory", out result);
                return result;
            }
        }

        public System.UInt64? TotalVideoMemory
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalVideoMemory", out result);
                return result;
            }
        }
    }
}