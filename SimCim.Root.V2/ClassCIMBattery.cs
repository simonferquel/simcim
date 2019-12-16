using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMBattery : CIMLogicalDevice
    {
        protected CIMBattery()
        {
        }

        protected CIMBattery(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? BatteryStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("BatteryStatus", out result);
                return result;
            }
        }

        public System.UInt16? Chemistry
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Chemistry", out result);
                return result;
            }
        }

        public System.UInt32? DesignCapacity
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DesignCapacity", out result);
                return result;
            }
        }

        public System.UInt64? DesignVoltage
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DesignVoltage", out result);
                return result;
            }
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

        public System.UInt32? ExpectedLife
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExpectedLife", out result);
                return result;
            }
        }

        public System.UInt32? FullChargeCapacity
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FullChargeCapacity", out result);
                return result;
            }
        }

        public System.UInt32? MaxRechargeTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxRechargeTime", out result);
                return result;
            }
        }

        public System.String SmartBatteryVersion
        {
            get
            {
                System.String result;
                this.GetProperty("SmartBatteryVersion", out result);
                return result;
            }
        }

        public System.UInt32? TimeOnBattery
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TimeOnBattery", out result);
                return result;
            }
        }

        public System.UInt32? TimeToFullCharge
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TimeToFullCharge", out result);
                return result;
            }
        }
    }
}