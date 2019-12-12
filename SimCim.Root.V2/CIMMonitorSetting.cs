using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMMonitorSetting : CIMElementSetting
    {
        protected CIMMonitorSetting()
        {
        }

        protected CIMMonitorSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMDesktopMonitor Element
        {
            get
            {
                CIMDesktopMonitor result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public new CIMMonitorResolution Setting
        {
            get
            {
                CIMMonitorResolution result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}