using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchOperationalData : MsvmEthernetSwitchData
    {
        public MsvmEthernetSwitchOperationalData()
        {
        }

        public MsvmEthernetSwitchOperationalData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CurrentSwitchingMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentSwitchingMode", out result);
                return result;
            }
        }

        public System.UInt32[] SupportedSwitchingModes
        {
            get
            {
                System.UInt32[] result;
                this.GetProperty("SupportedSwitchingModes", out result);
                return result;
            }
        }
    }
}