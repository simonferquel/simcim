using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersRemoteFXNetwork : Win32PerfRawData
    {
        public Win32PerfRawDataCountersRemoteFXNetwork()
        {
        }

        public Win32PerfRawDataCountersRemoteFXNetwork(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BaseTCPRTT
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BaseTCPRTT", out result);
                return result;
            }

            set
            {
                this.SetProperty("BaseTCPRTT", value);
            }
        }

        public System.UInt32? BaseUDPRTT
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BaseUDPRTT", out result);
                return result;
            }

            set
            {
                this.SetProperty("BaseUDPRTT", value);
            }
        }

        public System.UInt32? CurrentTCPBandwidth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentTCPBandwidth", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentTCPBandwidth", value);
            }
        }

        public System.UInt32? CurrentTCPRTT
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentTCPRTT", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentTCPRTT", value);
            }
        }

        public System.UInt32? CurrentUDPBandwidth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentUDPBandwidth", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentUDPBandwidth", value);
            }
        }

        public System.UInt32? CurrentUDPRTT
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentUDPRTT", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentUDPRTT", value);
            }
        }

        public System.UInt32? FECRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FECRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("FECRate", value);
            }
        }

        public System.UInt32? FECRateBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FECRate_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("FECRate_Base", value);
            }
        }

        public System.UInt32? LossRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LossRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("LossRate", value);
            }
        }

        public System.UInt32? LossRateBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LossRate_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("LossRate_Base", value);
            }
        }

        public System.UInt32? RetransmissionRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RetransmissionRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("RetransmissionRate", value);
            }
        }

        public System.UInt32? RetransmissionRateBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RetransmissionRate_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("RetransmissionRate_Base", value);
            }
        }

        public System.UInt32? SentRateP0
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentRateP0", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentRateP0", value);
            }
        }

        public System.UInt32? SentRateP1
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentRateP1", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentRateP1", value);
            }
        }

        public System.UInt32? SentRateP2
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentRateP2", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentRateP2", value);
            }
        }

        public System.UInt32? SentRateP3
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentRateP3", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentRateP3", value);
            }
        }

        public System.UInt32? TCPReceivedRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TCPReceivedRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPReceivedRate", value);
            }
        }

        public System.UInt32? TCPSentRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TCPSentRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPSentRate", value);
            }
        }

        public System.UInt32? TotalReceivedBytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalReceivedBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalReceivedBytes", value);
            }
        }

        public System.UInt32? TotalReceivedRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalReceivedRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalReceivedRate", value);
            }
        }

        public System.UInt32? TotalSentBytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalSentBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalSentBytes", value);
            }
        }

        public System.UInt32? TotalSentRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalSentRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalSentRate", value);
            }
        }

        public System.UInt32? UDPPacketsReceivedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UDPPacketsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("UDPPacketsReceivedPersec", value);
            }
        }

        public System.UInt32? UDPPacketsSentPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UDPPacketsSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("UDPPacketsSentPersec", value);
            }
        }

        public System.UInt32? UDPReceivedRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UDPReceivedRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("UDPReceivedRate", value);
            }
        }

        public System.UInt32? UDPSentRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UDPSentRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("UDPSentRate", value);
            }
        }
    }
}