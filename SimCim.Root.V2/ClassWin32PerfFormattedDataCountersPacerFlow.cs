using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersPacerFlow : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersPacerFlow()
        {
        }

        public Win32PerfFormattedDataCountersPacerFlow(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Averagepacketsinnetcard
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Averagepacketsinnetcard", out result);
                return result;
            }

            set
            {
                this.SetProperty("Averagepacketsinnetcard", value);
            }
        }

        public System.UInt32? Averagepacketsinsequencer
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Averagepacketsinsequencer", out result);
                return result;
            }

            set
            {
                this.SetProperty("Averagepacketsinsequencer", value);
            }
        }

        public System.UInt32? Averagepacketsinshaper
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Averagepacketsinshaper", out result);
                return result;
            }

            set
            {
                this.SetProperty("Averagepacketsinshaper", value);
            }
        }

        public System.UInt64? Bytesscheduled
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Bytesscheduled", out result);
                return result;
            }

            set
            {
                this.SetProperty("Bytesscheduled", value);
            }
        }

        public System.UInt64? BytesscheduledPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesscheduledPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesscheduledPersec", value);
            }
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

        public System.UInt32? Maximumpacketsinnetcard
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Maximumpacketsinnetcard", out result);
                return result;
            }

            set
            {
                this.SetProperty("Maximumpacketsinnetcard", value);
            }
        }

        public System.UInt32? Maxpacketsinsequencer
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Maxpacketsinsequencer", out result);
                return result;
            }

            set
            {
                this.SetProperty("Maxpacketsinsequencer", value);
            }
        }

        public System.UInt32? Maxpacketsinshaper
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Maxpacketsinshaper", out result);
                return result;
            }

            set
            {
                this.SetProperty("Maxpacketsinshaper", value);
            }
        }

        public System.UInt32? Nonconformingpacketsscheduled
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Nonconformingpacketsscheduled", out result);
                return result;
            }

            set
            {
                this.SetProperty("Nonconformingpacketsscheduled", value);
            }
        }

        public System.UInt32? NonconformingpacketsscheduledPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NonconformingpacketsscheduledPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NonconformingpacketsscheduledPersec", value);
            }
        }

        public System.UInt32? Nonconformingpacketstransmitted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Nonconformingpacketstransmitted", out result);
                return result;
            }

            set
            {
                this.SetProperty("Nonconformingpacketstransmitted", value);
            }
        }

        public System.UInt32? NonconformingpacketstransmittedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NonconformingpacketstransmittedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NonconformingpacketstransmittedPersec", value);
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

        public System.UInt32? Packetsscheduled
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Packetsscheduled", out result);
                return result;
            }

            set
            {
                this.SetProperty("Packetsscheduled", value);
            }
        }

        public System.UInt32? PacketsscheduledPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsscheduledPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsscheduledPersec", value);
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