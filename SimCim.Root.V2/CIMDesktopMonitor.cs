using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMDesktopMonitor : CIMDisplay
    {
        protected CIMDesktopMonitor()
        {
        }

        protected CIMDesktopMonitor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Bandwidth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Bandwidth", out result);
                return result;
            }
        }

        public System.UInt16? DisplayType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DisplayType", out result);
                return result;
            }
        }

        public System.UInt32? ScreenHeight
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ScreenHeight", out result);
                return result;
            }
        }

        public System.UInt32? ScreenWidth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ScreenWidth", out result);
                return result;
            }
        }

        public CIMMonitorResolution ResolveCIMMonitorSettingSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "CIM_MonitorSetting", "CIM_MonitorResolution", "Element", "Setting");
            return instances.Select(i => (CIMMonitorResolution)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}