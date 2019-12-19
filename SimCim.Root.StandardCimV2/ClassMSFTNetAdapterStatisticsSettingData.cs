using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterStatisticsSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterStatisticsSettingData()
        {
        }

        public MSFTNetAdapterStatisticsSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? OutboundDiscardedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutboundDiscardedPackets", out result);
                return result;
            }
        }

        public System.UInt64? OutboundPacketErrors
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutboundPacketErrors", out result);
                return result;
            }
        }

        public MSFTNetAdapterRdmaStatistics RdmaStatistics
        {
            get
            {
                MSFTNetAdapterRdmaStatistics result;
                this.GetInfrastructureObjectProperty("RdmaStatistics", out result);
                return result;
            }
        }

        public System.UInt64? ReceivedBroadcastBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceivedBroadcastBytes", out result);
                return result;
            }
        }

        public System.UInt64? ReceivedBroadcastPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceivedBroadcastPackets", out result);
                return result;
            }
        }

        public System.UInt64? ReceivedBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceivedBytes", out result);
                return result;
            }
        }

        public System.UInt64? ReceivedDiscardedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceivedDiscardedPackets", out result);
                return result;
            }
        }

        public System.UInt64? ReceivedMulticastBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceivedMulticastBytes", out result);
                return result;
            }
        }

        public System.UInt64? ReceivedMulticastPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceivedMulticastPackets", out result);
                return result;
            }
        }

        public System.UInt64? ReceivedPacketErrors
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceivedPacketErrors", out result);
                return result;
            }
        }

        public System.UInt64? ReceivedUnicastBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceivedUnicastBytes", out result);
                return result;
            }
        }

        public System.UInt64? ReceivedUnicastPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceivedUnicastPackets", out result);
                return result;
            }
        }

        public MSFTNetAdapterRscStatistics RscStatistics
        {
            get
            {
                MSFTNetAdapterRscStatistics result;
                this.GetInfrastructureObjectProperty("RscStatistics", out result);
                return result;
            }
        }

        public System.UInt64? SentBroadcastBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SentBroadcastBytes", out result);
                return result;
            }
        }

        public System.UInt64? SentBroadcastPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SentBroadcastPackets", out result);
                return result;
            }
        }

        public System.UInt64? SentBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SentBytes", out result);
                return result;
            }
        }

        public System.UInt64? SentMulticastBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SentMulticastBytes", out result);
                return result;
            }
        }

        public System.UInt64? SentMulticastPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SentMulticastPackets", out result);
                return result;
            }
        }

        public System.UInt64? SentUnicastBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SentUnicastBytes", out result);
                return result;
            }
        }

        public System.UInt64? SentUnicastPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SentUnicastPackets", out result);
                return result;
            }
        }

        public System.UInt32? SupportedStatistics
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SupportedStatistics", out result);
                return result;
            }
        }
    }
}