using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class CIMVideoControllerResolution : CIMSetting
    {
        public CIMVideoControllerResolution()
        {
        }

        public CIMVideoControllerResolution(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.UInt64? NumberOfColors
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NumberOfColors", out result);
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

        public Win32VideoController ResolveWin32VideoSettingsElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_VideoSettings", "Win32_VideoController", "Setting", "Element");
            return instances.Select(i => (Win32VideoController)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}