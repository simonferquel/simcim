using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Battery : CIMBattery
    {
        public Win32Battery()
        {
        }

        public Win32Battery(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BatteryRechargeTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BatteryRechargeTime", out result);
                return result;
            }
        }

        public System.UInt32? ExpectedBatteryLife
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExpectedBatteryLife", out result);
                return result;
            }
        }
    }
}