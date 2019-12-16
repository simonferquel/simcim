using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class CIMUSBHub : CIMUSBDevice
    {
        public CIMUSBHub()
        {
        }

        public CIMUSBHub(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? GangSwitched
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("GangSwitched", out result);
                return result;
            }

            set
            {
                this.SetProperty("GangSwitched", value);
            }
        }

        public System.Byte? NumberOfPorts
        {
            get
            {
                System.Byte? result;
                this.GetProperty("NumberOfPorts", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfPorts", value);
            }
        }
    }
}