using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmNumaNodeTopology : CIMManagedElement
    {
        public MsvmNumaNodeTopology()
        {
        }

        public MsvmNumaNodeTopology(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? CountOfMemoryBlocks
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CountOfMemoryBlocks", out result);
                return result;
            }

            set
            {
                this.SetProperty("CountOfMemoryBlocks", value);
            }
        }

        public System.UInt32? CountOfProcessors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CountOfProcessors", out result);
                return result;
            }

            set
            {
                this.SetProperty("CountOfProcessors", value);
            }
        }

        public System.UInt32? PhysicalNodeNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PhysicalNodeNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("PhysicalNodeNumber", value);
            }
        }

        public System.UInt32? VirtualNodeNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VirtualNodeNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualNodeNumber", value);
            }
        }

        public System.UInt32? VirtualSocketNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VirtualSocketNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualSocketNumber", value);
            }
        }
    }
}