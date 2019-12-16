using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMVideoController : CIMController
    {
        protected CIMVideoController()
        {
        }

        protected CIMVideoController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] AcceleratorCapabilities
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("AcceleratorCapabilities", out result);
                return result;
            }
        }

        public System.String[] CapabilityDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("CapabilityDescriptions", out result);
                return result;
            }
        }

        public System.UInt32? CurrentBitsPerPixel
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentBitsPerPixel", out result);
                return result;
            }
        }

        public System.UInt32? CurrentHorizontalResolution
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentHorizontalResolution", out result);
                return result;
            }
        }

        public System.UInt64? CurrentNumberOfColors
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CurrentNumberOfColors", out result);
                return result;
            }
        }

        public System.UInt32? CurrentNumberOfColumns
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentNumberOfColumns", out result);
                return result;
            }
        }

        public System.UInt32? CurrentNumberOfRows
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentNumberOfRows", out result);
                return result;
            }
        }

        public System.UInt32? CurrentRefreshRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentRefreshRate", out result);
                return result;
            }
        }

        public System.UInt16? CurrentScanMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CurrentScanMode", out result);
                return result;
            }
        }

        public System.UInt32? CurrentVerticalResolution
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentVerticalResolution", out result);
                return result;
            }
        }

        public System.UInt32? MaxMemorySupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxMemorySupported", out result);
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

        public System.UInt32? NumberOfVideoPages
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfVideoPages", out result);
                return result;
            }
        }

        public System.UInt16? VideoMemoryType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("VideoMemoryType", out result);
                return result;
            }
        }

        public System.String VideoProcessor
        {
            get
            {
                System.String result;
                this.GetProperty("VideoProcessor", out result);
                return result;
            }
        }
    }
}