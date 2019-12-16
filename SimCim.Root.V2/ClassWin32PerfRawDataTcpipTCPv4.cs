using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataTcpipTCPv4 : Win32PerfRawData
    {
        public Win32PerfRawDataTcpipTCPv4()
        {
        }

        public Win32PerfRawDataTcpipTCPv4(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ConnectionFailures
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectionFailures", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectionFailures", value);
            }
        }

        public System.UInt32? ConnectionsActive
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectionsActive", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectionsActive", value);
            }
        }

        public System.UInt32? ConnectionsEstablished
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectionsEstablished", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectionsEstablished", value);
            }
        }

        public System.UInt32? ConnectionsPassive
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectionsPassive", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectionsPassive", value);
            }
        }

        public System.UInt32? ConnectionsReset
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectionsReset", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectionsReset", value);
            }
        }

        public System.UInt32? SegmentsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SegmentsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SegmentsPersec", value);
            }
        }

        public System.UInt32? SegmentsReceivedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SegmentsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SegmentsReceivedPersec", value);
            }
        }

        public System.UInt32? SegmentsRetransmittedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SegmentsRetransmittedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SegmentsRetransmittedPersec", value);
            }
        }

        public System.UInt32? SegmentsSentPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SegmentsSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SegmentsSentPersec", value);
            }
        }
    }
}