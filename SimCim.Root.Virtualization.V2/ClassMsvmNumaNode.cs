using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmNumaNode : CIMEnabledLogicalElement
    {
        public MsvmNumaNode()
        {
        }

        public MsvmNumaNode(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CreationClassName", out result);
                return result;
            }

            set
            {
                this.SetProperty("CreationClassName", value);
            }
        }

        public System.UInt32? CurrentlyAssignedVirtualProcessors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentlyAssignedVirtualProcessors", out result);
                return result;
            }
        }

        public System.UInt64? CurrentlyConsumableMemoryBlocks
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CurrentlyConsumableMemoryBlocks", out result);
                return result;
            }
        }

        public System.String NodeID
        {
            get
            {
                System.String result;
                this.GetProperty("NodeID", out result);
                return result;
            }

            set
            {
                this.SetProperty("NodeID", value);
            }
        }

        public System.UInt32? NumberOfLogicalProcessors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfLogicalProcessors", out result);
                return result;
            }
        }

        public System.UInt32? NumberOfProcessorCores
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfProcessorCores", out result);
                return result;
            }
        }

        public System.String SystemCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemCreationClassName", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemCreationClassName", value);
            }
        }

        public System.String SystemName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemName", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemName", value);
            }
        }
    }
}