using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PrinterConfiguration : CIMSetting
    {
        public Win32PrinterConfiguration()
        {
        }

        public Win32PrinterConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BitsPerPel
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BitsPerPel", out result);
                return result;
            }
        }

        public System.Boolean? Collate
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Collate", out result);
                return result;
            }
        }

        public System.UInt32? Color
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Color", out result);
                return result;
            }
        }

        public System.UInt32? Copies
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Copies", out result);
                return result;
            }
        }

        public System.String DeviceName
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceName", out result);
                return result;
            }
        }

        public System.UInt32? DisplayFlags
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DisplayFlags", out result);
                return result;
            }
        }

        public System.UInt32? DisplayFrequency
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DisplayFrequency", out result);
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

        public System.UInt32? DriverVersion
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DriverVersion", out result);
                return result;
            }
        }

        public System.Boolean? Duplex
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Duplex", out result);
                return result;
            }
        }

        public System.String FormName
        {
            get
            {
                System.String result;
                this.GetProperty("FormName", out result);
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

        public System.UInt32? LogPixels
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogPixels", out result);
                return result;
            }
        }

        public System.UInt32? MediaType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MediaType", out result);
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

        public System.UInt32? Orientation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Orientation", out result);
                return result;
            }
        }

        public System.UInt32? PaperLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PaperLength", out result);
                return result;
            }
        }

        public System.String PaperSize
        {
            get
            {
                System.String result;
                this.GetProperty("PaperSize", out result);
                return result;
            }
        }

        public System.UInt32? PaperWidth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PaperWidth", out result);
                return result;
            }
        }

        public System.UInt32? PelsHeight
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PelsHeight", out result);
                return result;
            }
        }

        public System.UInt32? PelsWidth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PelsWidth", out result);
                return result;
            }
        }

        public System.UInt32? PrintQuality
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PrintQuality", out result);
                return result;
            }
        }

        public System.UInt32? Scale
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Scale", out result);
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

        public System.UInt32? TTOption
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TTOption", out result);
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

        public System.UInt32? XResolution
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("XResolution", out result);
                return result;
            }
        }

        public System.UInt32? YResolution
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("YResolution", out result);
                return result;
            }
        }

        public Win32Printer ResolveWin32PrinterSettingElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_PrinterSetting", "Win32_Printer", "Setting", "Element");
            return instances.Select(i => (Win32Printer)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}