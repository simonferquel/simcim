using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSerialPortSettingData : CIMResourceAllocationSettingData
    {
        public MsvmSerialPortSettingData()
        {
        }

        public MsvmSerialPortSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? DebuggerMode
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DebuggerMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("DebuggerMode", value);
            }
        }
    }
}