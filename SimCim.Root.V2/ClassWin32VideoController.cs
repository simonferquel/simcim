using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32VideoController : CIMPCVideoController
    {
        public Win32VideoController()
        {
        }

        public Win32VideoController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.UInt32? AdapterRAM
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AdapterRAM", out result);
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

        public System.UInt32? DitherType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DitherType", out result);
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

        public System.String DriverVersion
        {
            get
            {
                System.String result;
                this.GetProperty("DriverVersion", out result);
                return result;
            }
        }

        public System.UInt32? ICMIntent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ICMIntent", out result);
                return result;
            }
        }

        public System.UInt32? ICMMethod
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ICMMethod", out result);
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

        public System.Boolean? Monochrome
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Monochrome", out result);
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

        public System.UInt32? SpecificationVersion
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SpecificationVersion", out result);
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

        public System.String VideoModeDescription
        {
            get
            {
                System.String result;
                this.GetProperty("VideoModeDescription", out result);
                return result;
            }
        }
    }
}