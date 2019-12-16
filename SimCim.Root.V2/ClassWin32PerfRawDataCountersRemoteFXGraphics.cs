using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersRemoteFXGraphics : Win32PerfRawData
    {
        public Win32PerfRawDataCountersRemoteFXGraphics()
        {
        }

        public Win32PerfRawDataCountersRemoteFXGraphics(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AverageEncodingTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AverageEncodingTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageEncodingTime", value);
            }
        }

        public System.UInt32? FrameQuality
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FrameQuality", out result);
                return result;
            }

            set
            {
                this.SetProperty("FrameQuality", value);
            }
        }

        public System.UInt32? FramesSkippedPerSecondInsufficientClientResources
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FramesSkippedPerSecondInsufficientClientResources", out result);
                return result;
            }

            set
            {
                this.SetProperty("FramesSkippedPerSecondInsufficientClientResources", value);
            }
        }

        public System.UInt32? FramesSkippedPerSecondInsufficientNetworkResources
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FramesSkippedPerSecondInsufficientNetworkResources", out result);
                return result;
            }

            set
            {
                this.SetProperty("FramesSkippedPerSecondInsufficientNetworkResources", value);
            }
        }

        public System.UInt32? FramesSkippedPerSecondInsufficientServerResources
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FramesSkippedPerSecondInsufficientServerResources", out result);
                return result;
            }

            set
            {
                this.SetProperty("FramesSkippedPerSecondInsufficientServerResources", value);
            }
        }

        public System.UInt32? GraphicsCompressionratio
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("GraphicsCompressionratio", out result);
                return result;
            }

            set
            {
                this.SetProperty("GraphicsCompressionratio", value);
            }
        }

        public System.UInt32? InputFramesPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InputFramesPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("InputFramesPerSecond", value);
            }
        }

        public System.UInt32? OutputFramesPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutputFramesPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutputFramesPerSecond", value);
            }
        }

        public System.UInt32? SourceFramesPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SourceFramesPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("SourceFramesPerSecond", value);
            }
        }
    }
}