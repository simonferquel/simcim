using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmPhysicalGPUInfo : CIMManagedElement
    {
        public MsvmPhysicalGPUInfo()
        {
        }

        public MsvmPhysicalGPUInfo(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.String ID
        {
            get
            {
                System.String result;
                this.GetProperty("ID", out result);
                return result;
            }
        }

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
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