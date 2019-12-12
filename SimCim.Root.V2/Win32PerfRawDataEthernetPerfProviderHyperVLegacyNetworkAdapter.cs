using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataEthernetPerfProviderHyperVLegacyNetworkAdapter : Win32PerfRawData
    {
        public Win32PerfRawDataEthernetPerfProviderHyperVLegacyNetworkAdapter()
        {
        }

        public Win32PerfRawDataEthernetPerfProviderHyperVLegacyNetworkAdapter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? BytesDropped
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesDropped", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesDropped", value);
            }
        }

        public System.UInt64? BytesReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesReceivedPersec", value);
            }
        }

        public System.UInt64? BytesSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesSentPersec", value);
            }
        }

        public System.UInt64? FramesDropped
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FramesDropped", out result);
                return result;
            }

            set
            {
                this.SetProperty("FramesDropped", value);
            }
        }

        public System.UInt64? FramesReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FramesReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FramesReceivedPersec", value);
            }
        }

        public System.UInt64? FramesSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FramesSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FramesSentPersec", value);
            }
        }
    }
}