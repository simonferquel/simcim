using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataPeerNameResolutionProtocolPerfPeerNameResolutionProtocol : Win32PerfRawData
    {
        public Win32PerfRawDataPeerNameResolutionProtocolPerfPeerNameResolutionProtocol()
        {
        }

        public Win32PerfRawDataPeerNameResolutionProtocolPerfPeerNameResolutionProtocol(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Ackreceivedpersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Ackreceivedpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Ackreceivedpersecond", value);
            }
        }

        public System.UInt32? Acksentpersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Acksentpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Acksentpersecond", value);
            }
        }

        public System.UInt32? Advertisereceivedpersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Advertisereceivedpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Advertisereceivedpersecond", value);
            }
        }

        public System.UInt32? Advertisesentpersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Advertisesentpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Advertisesentpersecond", value);
            }
        }

        public System.UInt32? Authorityreceivedpersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Authorityreceivedpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Authorityreceivedpersecond", value);
            }
        }

        public System.UInt32? Authoritysentpersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Authoritysentpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Authoritysentpersecond", value);
            }
        }

        public System.UInt32? Averagebytesreceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Averagebytesreceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("Averagebytesreceived", value);
            }
        }

        public System.UInt32? Averagebytessent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Averagebytessent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Averagebytessent", value);
            }
        }

        public System.UInt32? CacheEntry
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheEntry", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheEntry", value);
            }
        }

        public System.UInt32? Estimatedcloudsize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Estimatedcloudsize", out result);
                return result;
            }

            set
            {
                this.SetProperty("Estimatedcloudsize", value);
            }
        }

        public System.UInt32? Floodreceivedpersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Floodreceivedpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Floodreceivedpersecond", value);
            }
        }

        public System.UInt32? Floodsentpersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Floodsentpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Floodsentpersecond", value);
            }
        }

        public System.UInt32? Inquirereceivedpersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Inquirereceivedpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Inquirereceivedpersecond", value);
            }
        }

        public System.UInt32? Inquiresentpersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Inquiresentpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Inquiresentpersecond", value);
            }
        }

        public System.UInt32? Lookupreceivedpersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Lookupreceivedpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Lookupreceivedpersecond", value);
            }
        }

        public System.UInt32? Lookupsentpersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Lookupsentpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Lookupsentpersecond", value);
            }
        }

        public System.UInt32? Receivefailures
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Receivefailures", out result);
                return result;
            }

            set
            {
                this.SetProperty("Receivefailures", value);
            }
        }

        public System.UInt32? Registration
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Registration", out result);
                return result;
            }

            set
            {
                this.SetProperty("Registration", value);
            }
        }

        public System.UInt32? Requestreceivedpersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Requestreceivedpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Requestreceivedpersecond", value);
            }
        }

        public System.UInt32? Requestsentpersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Requestsentpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Requestsentpersecond", value);
            }
        }

        public System.UInt32? Resolve
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Resolve", out result);
                return result;
            }

            set
            {
                this.SetProperty("Resolve", value);
            }
        }

        public System.UInt32? Sendfailures
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Sendfailures", out result);
                return result;
            }

            set
            {
                this.SetProperty("Sendfailures", value);
            }
        }

        public System.UInt32? Solicitreceivedpersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Solicitreceivedpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Solicitreceivedpersecond", value);
            }
        }

        public System.UInt32? Solicitsentpersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Solicitsentpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Solicitsentpersecond", value);
            }
        }

        public System.UInt32? Stalecacheentry
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Stalecacheentry", out result);
                return result;
            }

            set
            {
                this.SetProperty("Stalecacheentry", value);
            }
        }

        public System.UInt32? Unknownmessagetypereceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Unknownmessagetypereceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("Unknownmessagetypereceived", value);
            }
        }
    }
}