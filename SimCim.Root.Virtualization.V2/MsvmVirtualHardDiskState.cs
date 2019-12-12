using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualHardDiskState : GenericInfrastructureObject
    {
        public MsvmVirtualHardDiskState()
        {
        }

        public MsvmVirtualHardDiskState(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Alignment
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Alignment", out result);
                return result;
            }
        }

        public System.UInt64? FileSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FileSize", out result);
                return result;
            }
        }

        public System.UInt32? FragmentationPercentage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FragmentationPercentage", out result);
                return result;
            }
        }

        public System.Boolean? InUse
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("InUse", out result);
                return result;
            }
        }

        public System.UInt64? MinInternalSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MinInternalSize", out result);
                return result;
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
        }

        public System.DateTime? Timestamp
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("Timestamp", out result);
                return result;
            }
        }
    }
}