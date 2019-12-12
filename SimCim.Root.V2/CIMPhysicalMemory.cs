using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPhysicalMemory : CIMChip
    {
        protected CIMPhysicalMemory()
        {
        }

        protected CIMPhysicalMemory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String BankLabel
        {
            get
            {
                System.String result;
                this.GetProperty("BankLabel", out result);
                return result;
            }
        }

        public System.UInt64? Capacity
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Capacity", out result);
                return result;
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
        }

        public System.UInt32? InterleavePosition
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterleavePosition", out result);
                return result;
            }
        }

        public System.UInt16? MemoryType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MemoryType", out result);
                return result;
            }
        }

        public System.UInt32? PositionInRow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PositionInRow", out result);
                return result;
            }
        }

        public System.UInt32? Speed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Speed", out result);
                return result;
            }
        }

        public System.UInt16? TotalWidth
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TotalWidth", out result);
                return result;
            }
        }
    }
}