using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMMonitorResolution : CIMSetting
    {
        protected CIMMonitorResolution()
        {
        }

        protected CIMMonitorResolution(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? HorizontalResolution
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HorizontalResolution", out result);
                return result;
            }
        }

        public System.UInt32? MaxRefreshRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxRefreshRate", out result);
                return result;
            }
        }

        public System.UInt32? MinRefreshRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MinRefreshRate", out result);
                return result;
            }
        }

        public System.UInt32? RefreshRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RefreshRate", out result);
                return result;
            }
        }

        public System.UInt16? ScanMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ScanMode", out result);
                return result;
            }
        }

        public System.UInt32? VerticalResolution
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VerticalResolution", out result);
                return result;
            }
        }

        public CIMDesktopMonitor ResolveCIMMonitorSettingElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "CIM_MonitorSetting", "CIM_DesktopMonitor", "Setting", "Element");
            return instances.Select(i => (CIMDesktopMonitor)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}