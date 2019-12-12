using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DisplayConfiguration : CIMSetting
    {
        public Win32DisplayConfiguration()
        {
        }

        public Win32DisplayConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.UInt32? LogPixels
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogPixels", out result);
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

        public System.UInt32? SpecificationVersion
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SpecificationVersion", out result);
                return result;
            }
        }
    }
}