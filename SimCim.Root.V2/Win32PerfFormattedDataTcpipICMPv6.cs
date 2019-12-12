using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataTcpipICMPv6 : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataTcpipICMPv6()
        {
        }

        public Win32PerfFormattedDataTcpipICMPv6(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? MessagesOutboundErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MessagesOutboundErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("MessagesOutboundErrors", value);
            }
        }

        public System.UInt32? MessagesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MessagesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MessagesPersec", value);
            }
        }

        public System.UInt32? MessagesReceivedErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MessagesReceivedErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("MessagesReceivedErrors", value);
            }
        }

        public System.UInt32? MessagesReceivedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MessagesReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MessagesReceivedPersec", value);
            }
        }

        public System.UInt32? MessagesSentPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MessagesSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MessagesSentPersec", value);
            }
        }

        public System.UInt32? ReceivedDestUnreachable
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedDestUnreachable", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedDestUnreachable", value);
            }
        }

        public System.UInt32? ReceivedEchoPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedEchoPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedEchoPersec", value);
            }
        }

        public System.UInt32? ReceivedEchoReplyPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedEchoReplyPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedEchoReplyPersec", value);
            }
        }

        public System.UInt32? ReceivedMembershipQuery
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedMembershipQuery", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedMembershipQuery", value);
            }
        }

        public System.UInt32? ReceivedMembershipReduction
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedMembershipReduction", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedMembershipReduction", value);
            }
        }

        public System.UInt32? ReceivedMembershipReport
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedMembershipReport", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedMembershipReport", value);
            }
        }

        public System.UInt32? ReceivedNeighborAdvert
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedNeighborAdvert", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedNeighborAdvert", value);
            }
        }

        public System.UInt32? ReceivedNeighborSolicit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedNeighborSolicit", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedNeighborSolicit", value);
            }
        }

        public System.UInt32? ReceivedPacketTooBig
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedPacketTooBig", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedPacketTooBig", value);
            }
        }

        public System.UInt32? ReceivedParameterProblem
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedParameterProblem", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedParameterProblem", value);
            }
        }

        public System.UInt32? ReceivedRedirectPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedRedirectPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedRedirectPersec", value);
            }
        }

        public System.UInt32? ReceivedRouterAdvert
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedRouterAdvert", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedRouterAdvert", value);
            }
        }

        public System.UInt32? ReceivedRouterSolicit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedRouterSolicit", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedRouterSolicit", value);
            }
        }

        public System.UInt32? ReceivedTimeExceeded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedTimeExceeded", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedTimeExceeded", value);
            }
        }

        public System.UInt32? SentDestinationUnreachable
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentDestinationUnreachable", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentDestinationUnreachable", value);
            }
        }

        public System.UInt32? SentEchoPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentEchoPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentEchoPersec", value);
            }
        }

        public System.UInt32? SentEchoReplyPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentEchoReplyPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentEchoReplyPersec", value);
            }
        }

        public System.UInt32? SentMembershipQuery
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentMembershipQuery", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentMembershipQuery", value);
            }
        }

        public System.UInt32? SentMembershipReduction
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentMembershipReduction", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentMembershipReduction", value);
            }
        }

        public System.UInt32? SentMembershipReport
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentMembershipReport", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentMembershipReport", value);
            }
        }

        public System.UInt32? SentNeighborAdvert
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentNeighborAdvert", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentNeighborAdvert", value);
            }
        }

        public System.UInt32? SentNeighborSolicit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentNeighborSolicit", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentNeighborSolicit", value);
            }
        }

        public System.UInt32? SentPacketTooBig
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentPacketTooBig", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentPacketTooBig", value);
            }
        }

        public System.UInt32? SentParameterProblem
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentParameterProblem", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentParameterProblem", value);
            }
        }

        public System.UInt32? SentRedirectPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentRedirectPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentRedirectPersec", value);
            }
        }

        public System.UInt32? SentRouterAdvert
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentRouterAdvert", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentRouterAdvert", value);
            }
        }

        public System.UInt32? SentRouterSolicit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentRouterSolicit", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentRouterSolicit", value);
            }
        }

        public System.UInt32? SentTimeExceeded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentTimeExceeded", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentTimeExceeded", value);
            }
        }
    }
}