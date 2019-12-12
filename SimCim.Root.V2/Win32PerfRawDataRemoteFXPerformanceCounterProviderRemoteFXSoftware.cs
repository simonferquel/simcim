using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataRemoteFXPerformanceCounterProviderRemoteFXSoftware : Win32PerfRawData
    {
        public Win32PerfRawDataRemoteFXPerformanceCounterProviderRemoteFXSoftware()
        {
        }

        public Win32PerfRawDataRemoteFXPerformanceCounterProviderRemoteFXSoftware(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CaptureRateformonitor1
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CaptureRateformonitor1", out result);
                return result;
            }

            set
            {
                this.SetProperty("CaptureRateformonitor1", value);
            }
        }

        public System.UInt32? CaptureRateformonitor2
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CaptureRateformonitor2", out result);
                return result;
            }

            set
            {
                this.SetProperty("CaptureRateformonitor2", value);
            }
        }

        public System.UInt32? CaptureRateformonitor3
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CaptureRateformonitor3", out result);
                return result;
            }

            set
            {
                this.SetProperty("CaptureRateformonitor3", value);
            }
        }

        public System.UInt32? CaptureRateformonitor4
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CaptureRateformonitor4", out result);
                return result;
            }

            set
            {
                this.SetProperty("CaptureRateformonitor4", value);
            }
        }

        public System.UInt32? CaptureRateformonitor5
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CaptureRateformonitor5", out result);
                return result;
            }

            set
            {
                this.SetProperty("CaptureRateformonitor5", value);
            }
        }

        public System.UInt32? CaptureRateformonitor6
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CaptureRateformonitor6", out result);
                return result;
            }

            set
            {
                this.SetProperty("CaptureRateformonitor6", value);
            }
        }

        public System.UInt32? CaptureRateformonitor7
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CaptureRateformonitor7", out result);
                return result;
            }

            set
            {
                this.SetProperty("CaptureRateformonitor7", value);
            }
        }

        public System.UInt32? CaptureRateformonitor8
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CaptureRateformonitor8", out result);
                return result;
            }

            set
            {
                this.SetProperty("CaptureRateformonitor8", value);
            }
        }

        public System.UInt32? CompressionRatio
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CompressionRatio", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompressionRatio", value);
            }
        }

        public System.UInt32? DelayedFramesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DelayedFramesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DelayedFramesPersec", value);
            }
        }

        public System.UInt64? GPUresponsetimefromCapture
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("GPUresponsetimefromCapture", out result);
                return result;
            }

            set
            {
                this.SetProperty("GPUresponsetimefromCapture", value);
            }
        }

        public System.UInt32? GPUresponsetimefromCaptureBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("GPUresponsetimefromCapture_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("GPUresponsetimefromCapture_Base", value);
            }
        }

        public System.UInt64? GPUresponsetimefromRender
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("GPUresponsetimefromRender", out result);
                return result;
            }

            set
            {
                this.SetProperty("GPUresponsetimefromRender", value);
            }
        }

        public System.UInt32? GPUresponsetimefromRenderBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("GPUresponsetimefromRender_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("GPUresponsetimefromRender_Base", value);
            }
        }

        public System.UInt32? OutputBytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutputBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutputBytes", value);
            }
        }

        public System.UInt32? Renderrateformonitor1
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Renderrateformonitor1", out result);
                return result;
            }

            set
            {
                this.SetProperty("Renderrateformonitor1", value);
            }
        }

        public System.UInt32? Renderrateformonitor2
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Renderrateformonitor2", out result);
                return result;
            }

            set
            {
                this.SetProperty("Renderrateformonitor2", value);
            }
        }

        public System.UInt32? Renderrateformonitor3
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Renderrateformonitor3", out result);
                return result;
            }

            set
            {
                this.SetProperty("Renderrateformonitor3", value);
            }
        }

        public System.UInt32? Renderrateformonitor4
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Renderrateformonitor4", out result);
                return result;
            }

            set
            {
                this.SetProperty("Renderrateformonitor4", value);
            }
        }

        public System.UInt32? Renderrateformonitor5
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Renderrateformonitor5", out result);
                return result;
            }

            set
            {
                this.SetProperty("Renderrateformonitor5", value);
            }
        }

        public System.UInt32? Renderrateformonitor6
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Renderrateformonitor6", out result);
                return result;
            }

            set
            {
                this.SetProperty("Renderrateformonitor6", value);
            }
        }

        public System.UInt32? Renderrateformonitor7
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Renderrateformonitor7", out result);
                return result;
            }

            set
            {
                this.SetProperty("Renderrateformonitor7", value);
            }
        }

        public System.UInt32? Renderrateformonitor8
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Renderrateformonitor8", out result);
                return result;
            }

            set
            {
                this.SetProperty("Renderrateformonitor8", value);
            }
        }

        public System.UInt32? WaitingforclientcountPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WaitingforclientcountPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WaitingforclientcountPersec", value);
            }
        }
    }
}