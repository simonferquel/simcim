using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPowerSupply : CIMLogicalDevice
    {
        protected CIMPowerSupply()
        {
        }

        protected CIMPowerSupply(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? ActiveInputVoltage
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ActiveInputVoltage", out result);
                return result;
            }
        }

        public System.Boolean? IsSwitchingSupply
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsSwitchingSupply", out result);
                return result;
            }
        }

        public System.UInt32? Range1InputFrequencyHigh
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Range1InputFrequencyHigh", out result);
                return result;
            }
        }

        public System.UInt32? Range1InputFrequencyLow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Range1InputFrequencyLow", out result);
                return result;
            }
        }

        public System.UInt32? Range1InputVoltageHigh
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Range1InputVoltageHigh", out result);
                return result;
            }
        }

        public System.UInt32? Range1InputVoltageLow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Range1InputVoltageLow", out result);
                return result;
            }
        }

        public System.UInt32? Range2InputFrequencyHigh
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Range2InputFrequencyHigh", out result);
                return result;
            }
        }

        public System.UInt32? Range2InputFrequencyLow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Range2InputFrequencyLow", out result);
                return result;
            }
        }

        public System.UInt32? Range2InputVoltageHigh
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Range2InputVoltageHigh", out result);
                return result;
            }
        }

        public System.UInt32? Range2InputVoltageLow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Range2InputVoltageLow", out result);
                return result;
            }
        }

        public System.UInt32? TotalOutputPower
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalOutputPower", out result);
                return result;
            }
        }

        public System.UInt16? TypeOfRangeSwitching
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TypeOfRangeSwitching", out result);
                return result;
            }
        }
    }
}