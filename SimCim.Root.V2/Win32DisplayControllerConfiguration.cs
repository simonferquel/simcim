using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DisplayControllerConfiguration : CIMSetting
    {
        public Win32DisplayControllerConfiguration()
        {
        }

        public Win32DisplayControllerConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BitsPerPixel
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BitsPerPixel", out result);
                return result;
            }
        }

        public System.UInt32? ColorPlanes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ColorPlanes", out result);
                return result;
            }
        }

        public System.UInt32? DeviceEntriesInAColorTable
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DeviceEntriesInAColorTable", out result);
                return result;
            }
        }

        public System.UInt32? DeviceSpecificPens
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DeviceSpecificPens", out result);
                return result;
            }
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

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
                return result;
            }
        }

        public System.Int32? RefreshRate
        {
            get
            {
                System.Int32? result;
                this.GetProperty("RefreshRate", out result);
                return result;
            }
        }

        public System.UInt32? ReservedSystemPaletteEntries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReservedSystemPaletteEntries", out result);
                return result;
            }
        }

        public System.UInt32? SystemPaletteEntries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SystemPaletteEntries", out result);
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

        public System.String VideoMode
        {
            get
            {
                System.String result;
                this.GetProperty("VideoMode", out result);
                return result;
            }
        }
    }
}