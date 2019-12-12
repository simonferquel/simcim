using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataMSDTCBridge4000MSDTCBridge4000 : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataMSDTCBridge4000MSDTCBridge4000()
        {
        }

        public Win32PerfFormattedDataMSDTCBridge4000MSDTCBridge4000(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Averageparticipantcommitresponsetime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Averageparticipantcommitresponsetime", out result);
                return result;
            }

            set
            {
                this.SetProperty("Averageparticipantcommitresponsetime", value);
            }
        }

        public System.UInt32? Averageparticipantprepareresponsetime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Averageparticipantprepareresponsetime", out result);
                return result;
            }

            set
            {
                this.SetProperty("Averageparticipantprepareresponsetime", value);
            }
        }

        public System.UInt32? CommitretrycountPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CommitretrycountPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CommitretrycountPersec", value);
            }
        }

        public System.UInt32? FaultsreceivedcountPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FaultsreceivedcountPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FaultsreceivedcountPersec", value);
            }
        }

        public System.UInt32? FaultssentcountPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FaultssentcountPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FaultssentcountPersec", value);
            }
        }

        public System.UInt32? MessagesendfailuresPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MessagesendfailuresPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("MessagesendfailuresPersec", value);
            }
        }

        public System.UInt32? PreparedretrycountPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PreparedretrycountPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PreparedretrycountPersec", value);
            }
        }

        public System.UInt32? PrepareretrycountPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PrepareretrycountPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrepareretrycountPersec", value);
            }
        }

        public System.UInt32? ReplayretrycountPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReplayretrycountPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReplayretrycountPersec", value);
            }
        }
    }
}