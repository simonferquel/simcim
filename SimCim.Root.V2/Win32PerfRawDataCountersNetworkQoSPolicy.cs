using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersNetworkQoSPolicy : Win32PerfRawData
    {
        public Win32PerfRawDataCountersNetworkQoSPolicy()
        {
        }

        public Win32PerfRawDataCountersNetworkQoSPolicy(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? Bytestransmitted
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Bytestransmitted", out result);
                return result;
            }

            set
            {
                this.SetProperty("Bytestransmitted", value);
            }
        }

        public System.UInt64? BytestransmittedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytestransmittedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytestransmittedPersec", value);
            }
        }

        public System.UInt32? Packetsdropped
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Packetsdropped", out result);
                return result;
            }

            set
            {
                this.SetProperty("Packetsdropped", value);
            }
        }

        public System.UInt32? PacketsdroppedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsdroppedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsdroppedPersec", value);
            }
        }

        public System.UInt32? Packetstransmitted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Packetstransmitted", out result);
                return result;
            }

            set
            {
                this.SetProperty("Packetstransmitted", value);
            }
        }

        public System.UInt32? PacketstransmittedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketstransmittedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketstransmittedPersec", value);
            }
        }
    }
}