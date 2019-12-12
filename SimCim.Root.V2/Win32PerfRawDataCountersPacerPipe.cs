using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersPacerPipe : Win32PerfRawData
    {
        public Win32PerfRawDataCountersPacerPipe()
        {
        }

        public Win32PerfRawDataCountersPacerPipe(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.UInt32? Flowmodsrejected
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Flowmodsrejected", out result);
                return result;
            }

            set
            {
                this.SetProperty("Flowmodsrejected", value);
            }
        }

        public System.UInt32? Flowsclosed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Flowsclosed", out result);
                return result;
            }

            set
            {
                this.SetProperty("Flowsclosed", value);
            }
        }

        public System.UInt32? Flowsmodified
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Flowsmodified", out result);
                return result;
            }

            set
            {
                this.SetProperty("Flowsmodified", value);
            }
        }

        public System.UInt32? Flowsopened
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Flowsopened", out result);
                return result;
            }

            set
            {
                this.SetProperty("Flowsopened", value);
            }
        }

        public System.UInt32? Flowsrejected
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Flowsrejected", out result);
                return result;
            }

            set
            {
                this.SetProperty("Flowsrejected", value);
            }
        }

        public System.UInt32? Maxpacketsinnetcard
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Maxpacketsinnetcard", out result);
                return result;
            }

            set
            {
                this.SetProperty("Maxpacketsinnetcard", value);
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

        public System.UInt32? Maxsimultaneousflows
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Maxsimultaneousflows", out result);
                return result;
            }

            set
            {
                this.SetProperty("Maxsimultaneousflows", value);
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

        public System.UInt32? Outofpackets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Outofpackets", out result);
                return result;
            }

            set
            {
                this.SetProperty("Outofpackets", value);
            }
        }
    }
}