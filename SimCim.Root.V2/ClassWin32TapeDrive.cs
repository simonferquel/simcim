using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32TapeDrive : CIMTapeDrive
    {
        public Win32TapeDrive()
        {
        }

        public Win32TapeDrive(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Compression
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Compression", out result);
                return result;
            }
        }

        public System.UInt32? ECC
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ECC", out result);
                return result;
            }
        }

        public System.UInt32? FeaturesHigh
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FeaturesHigh", out result);
                return result;
            }
        }

        public System.UInt32? FeaturesLow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FeaturesLow", out result);
                return result;
            }
        }

        public System.String Id
        {
            get
            {
                System.String result;
                this.GetProperty("Id", out result);
                return result;
            }
        }

        public System.String Manufacturer
        {
            get
            {
                System.String result;
                this.GetProperty("Manufacturer", out result);
                return result;
            }
        }

        public System.String MediaType
        {
            get
            {
                System.String result;
                this.GetProperty("MediaType", out result);
                return result;
            }
        }

        public System.UInt32? ReportSetMarks
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReportSetMarks", out result);
                return result;
            }
        }
    }
}