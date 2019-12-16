using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataTcpipICMP : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataTcpipICMP()
        {
        }

        public Win32PerfFormattedDataTcpipICMP(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.UInt32? ReceivedAddressMask
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedAddressMask", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedAddressMask", value);
            }
        }

        public System.UInt32? ReceivedAddressMaskReply
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedAddressMaskReply", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedAddressMaskReply", value);
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

        public System.UInt32? ReceivedSourceQuench
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedSourceQuench", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedSourceQuench", value);
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

        public System.UInt32? ReceivedTimestampPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedTimestampPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedTimestampPersec", value);
            }
        }

        public System.UInt32? ReceivedTimestampReplyPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivedTimestampReplyPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedTimestampReplyPersec", value);
            }
        }

        public System.UInt32? SentAddressMask
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentAddressMask", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentAddressMask", value);
            }
        }

        public System.UInt32? SentAddressMaskReply
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentAddressMaskReply", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentAddressMaskReply", value);
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

        public System.UInt32? SentSourceQuench
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentSourceQuench", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentSourceQuench", value);
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

        public System.UInt32? SentTimestampPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentTimestampPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentTimestampPersec", value);
            }
        }

        public System.UInt32? SentTimestampReplyPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SentTimestampReplyPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentTimestampReplyPersec", value);
            }
        }
    }
}