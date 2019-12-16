using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DesktopMonitor : CIMDesktopMonitor
    {
        public Win32DesktopMonitor()
        {
        }

        public Win32DesktopMonitor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String MonitorManufacturer
        {
            get
            {
                System.String result;
                this.GetProperty("MonitorManufacturer", out result);
                return result;
            }
        }

        public System.String MonitorType
        {
            get
            {
                System.String result;
                this.GetProperty("MonitorType", out result);
                return result;
            }
        }

        public System.UInt32? PixelsPerXLogicalInch
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PixelsPerXLogicalInch", out result);
                return result;
            }
        }

        public System.UInt32? PixelsPerYLogicalInch
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PixelsPerYLogicalInch", out result);
                return result;
            }
        }
    }
}