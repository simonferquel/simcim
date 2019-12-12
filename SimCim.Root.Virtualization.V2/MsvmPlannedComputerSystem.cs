using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmPlannedComputerSystem : CIMComputerSystem
    {
        public MsvmPlannedComputerSystem()
        {
        }

        public MsvmPlannedComputerSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] AssignedNumaNodeList
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("AssignedNumaNodeList", out result);
                return result;
            }
        }

        public System.UInt64? OnTimeInMilliseconds
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OnTimeInMilliseconds", out result);
                return result;
            }
        }

        public System.UInt32? ProcessID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessID", out result);
                return result;
            }
        }

        public System.DateTime? TimeOfLastConfigurationChange
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeOfLastConfigurationChange", out result);
                return result;
            }
        }
    }
}