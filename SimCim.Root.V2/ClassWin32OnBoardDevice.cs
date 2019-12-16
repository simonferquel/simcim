using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OnBoardDevice : CIMPhysicalComponent
    {
        public Win32OnBoardDevice()
        {
        }

        public Win32OnBoardDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? DeviceType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DeviceType", out result);
                return result;
            }
        }

        public System.Boolean? Enabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Enabled", out result);
                return result;
            }
        }
    }
}