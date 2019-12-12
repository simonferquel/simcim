using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataPerfNetBrowser : Win32PerfRawData
    {
        public Win32PerfRawDataPerfNetBrowser()
        {
        }

        public Win32PerfRawDataPerfNetBrowser(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AnnouncementsDomainPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AnnouncementsDomainPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AnnouncementsDomainPersec", value);
            }
        }

        public System.UInt64? AnnouncementsServerPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AnnouncementsServerPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AnnouncementsServerPersec", value);
            }
        }

        public System.UInt64? AnnouncementsTotalPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AnnouncementsTotalPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AnnouncementsTotalPersec", value);
            }
        }

        public System.UInt32? DuplicateMasterAnnouncements
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DuplicateMasterAnnouncements", out result);
                return result;
            }

            set
            {
                this.SetProperty("DuplicateMasterAnnouncements", value);
            }
        }

        public System.UInt32? ElectionPacketsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ElectionPacketsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ElectionPacketsPersec", value);
            }
        }

        public System.UInt32? EnumerationsDomainPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EnumerationsDomainPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnumerationsDomainPersec", value);
            }
        }

        public System.UInt32? EnumerationsOtherPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EnumerationsOtherPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnumerationsOtherPersec", value);
            }
        }

        public System.UInt32? EnumerationsServerPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EnumerationsServerPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnumerationsServerPersec", value);
            }
        }

        public System.UInt32? EnumerationsTotalPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EnumerationsTotalPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnumerationsTotalPersec", value);
            }
        }

        public System.UInt64? IllegalDatagramsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IllegalDatagramsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IllegalDatagramsPersec", value);
            }
        }

        public System.UInt32? MailslotAllocationsFailed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MailslotAllocationsFailed", out result);
                return result;
            }

            set
            {
                this.SetProperty("MailslotAllocationsFailed", value);
            }
        }

        public System.UInt32? MailslotOpensFailedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MailslotOpensFailedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MailslotOpensFailedPersec", value);
            }
        }

        public System.UInt32? MailslotReceivesFailed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MailslotReceivesFailed", out result);
                return result;
            }

            set
            {
                this.SetProperty("MailslotReceivesFailed", value);
            }
        }

        public System.UInt32? MailslotWritesFailed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MailslotWritesFailed", out result);
                return result;
            }

            set
            {
                this.SetProperty("MailslotWritesFailed", value);
            }
        }

        public System.UInt32? MailslotWritesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MailslotWritesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MailslotWritesPersec", value);
            }
        }

        public System.UInt32? MissedMailslotDatagrams
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MissedMailslotDatagrams", out result);
                return result;
            }

            set
            {
                this.SetProperty("MissedMailslotDatagrams", value);
            }
        }

        public System.UInt32? MissedServerAnnouncements
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MissedServerAnnouncements", out result);
                return result;
            }

            set
            {
                this.SetProperty("MissedServerAnnouncements", value);
            }
        }

        public System.UInt32? MissedServerListRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MissedServerListRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("MissedServerListRequests", value);
            }
        }

        public System.UInt32? ServerAnnounceAllocationsFailedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ServerAnnounceAllocationsFailedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServerAnnounceAllocationsFailedPersec", value);
            }
        }

        public System.UInt32? ServerListRequestsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ServerListRequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServerListRequestsPersec", value);
            }
        }
    }
}