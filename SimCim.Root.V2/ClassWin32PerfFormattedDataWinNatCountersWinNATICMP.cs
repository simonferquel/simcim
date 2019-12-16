using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataWinNatCountersWinNATICMP : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataWinNatCountersWinNATICMP()
        {
        }

        public Win32PerfFormattedDataWinNatCountersWinNATICMP(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? NumberOfBindings
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfBindings", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfBindings", value);
            }
        }

        public System.UInt32? NumberOfSessions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfSessions", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfSessions", value);
            }
        }

        public System.UInt32? NumExtToIntTranslations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumExtToIntTranslations", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumExtToIntTranslations", value);
            }
        }

        public System.UInt32? NumIntToExtTranslations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumIntToExtTranslations", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumIntToExtTranslations", value);
            }
        }

        public System.UInt32? NumPacketsDropped
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumPacketsDropped", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumPacketsDropped", value);
            }
        }

        public System.UInt32? NumSessionsTimedOut
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumSessionsTimedOut", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumSessionsTimedOut", value);
            }
        }
    }
}