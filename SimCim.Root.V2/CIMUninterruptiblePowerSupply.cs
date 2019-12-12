using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMUninterruptiblePowerSupply : CIMPowerSupply
    {
        protected CIMUninterruptiblePowerSupply()
        {
        }

        protected CIMUninterruptiblePowerSupply(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? EstimatedChargeRemaining
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EstimatedChargeRemaining", out result);
                return result;
            }
        }

        public System.UInt32? EstimatedRunTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EstimatedRunTime", out result);
                return result;
            }
        }

        public System.UInt16? RemainingCapacityStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("RemainingCapacityStatus", out result);
                return result;
            }
        }

        public System.UInt32? TimeOnBackup
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TimeOnBackup", out result);
                return result;
            }
        }
    }
}