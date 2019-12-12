using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32VideoConfiguration : CIMSetting
    {
        public Win32VideoConfiguration()
        {
        }

        public Win32VideoConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActualColorResolution
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActualColorResolution", out result);
                return result;
            }
        }

        public System.String AdapterChipType
        {
            get
            {
                System.String result;
                this.GetProperty("AdapterChipType", out result);
                return result;
            }
        }

        public System.String AdapterCompatibility
        {
            get
            {
                System.String result;
                this.GetProperty("AdapterCompatibility", out result);
                return result;
            }
        }

        public System.String AdapterDACType
        {
            get
            {
                System.String result;
                this.GetProperty("AdapterDACType", out result);
                return result;
            }
        }

        public System.String AdapterDescription
        {
            get
            {
                System.String result;
                this.GetProperty("AdapterDescription", out result);
                return result;
            }
        }

        public System.UInt32? AdapterRAM
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AdapterRAM", out result);
                return result;
            }
        }

        public System.String AdapterType
        {
            get
            {
                System.String result;
                this.GetProperty("AdapterType", out result);
                return result;
            }
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

        public System.UInt32? ColorTableEntries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ColorTableEntries", out result);
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

        public System.DateTime? DriverDate
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("DriverDate", out result);
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

        public System.String InfFilename
        {
            get
            {
                System.String result;
                this.GetProperty("InfFilename", out result);
                return result;
            }
        }

        public System.String InfSection
        {
            get
            {
                System.String result;
                this.GetProperty("InfSection", out result);
                return result;
            }
        }

        public System.String InstalledDisplayDrivers
        {
            get
            {
                System.String result;
                this.GetProperty("InstalledDisplayDrivers", out result);
                return result;
            }
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

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
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

        public System.UInt32? RefreshRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RefreshRate", out result);
                return result;
            }
        }

        public System.String ScanMode
        {
            get
            {
                System.String result;
                this.GetProperty("ScanMode", out result);
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
    }
}