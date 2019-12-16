using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMTransportChannel : Win32PerfRawData
    {
        public Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMTransportChannel()
        {
        }

        public Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvscRemoteFXSynth3DVSCVMTransportChannel(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Numberofdataavailableeventwasreset
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Numberofdataavailableeventwasreset", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofdataavailableeventwasreset", value);
            }
        }

        public System.UInt64? Numberofdataavailableeventwasresetpersecond
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Numberofdataavailableeventwasresetpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofdataavailableeventwasresetpersecond", value);
            }
        }

        public System.UInt32? Numberofdataavailablesignalsreceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Numberofdataavailablesignalsreceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofdataavailablesignalsreceived", value);
            }
        }

        public System.UInt64? Numberofdataavailablesignalsreceivedpersecond
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Numberofdataavailablesignalsreceivedpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofdataavailablesignalsreceivedpersecond", value);
            }
        }

        public System.UInt32? Numberofdataavailablesignalssent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Numberofdataavailablesignalssent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofdataavailablesignalssent", value);
            }
        }

        public System.UInt64? Numberofdataavailablesignalssentpersecond
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Numberofdataavailablesignalssentpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofdataavailablesignalssentpersecond", value);
            }
        }

        public System.UInt32? Numberofspaceavailableeventwasreset
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Numberofspaceavailableeventwasreset", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofspaceavailableeventwasreset", value);
            }
        }

        public System.UInt64? Numberofspaceavailableeventwasresetpersecond
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Numberofspaceavailableeventwasresetpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofspaceavailableeventwasresetpersecond", value);
            }
        }

        public System.UInt32? Numberofspaceavailablesignalsreceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Numberofspaceavailablesignalsreceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofspaceavailablesignalsreceived", value);
            }
        }

        public System.UInt64? Numberofspaceavailablesignalsreceivedpersecond
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Numberofspaceavailablesignalsreceivedpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofspaceavailablesignalsreceivedpersecond", value);
            }
        }

        public System.UInt32? Numberofspaceavailablesignalssent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Numberofspaceavailablesignalssent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofspaceavailablesignalssent", value);
            }
        }

        public System.UInt64? Numberofspaceavailablesignalssentpersecond
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Numberofspaceavailablesignalssentpersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofspaceavailablesignalssentpersecond", value);
            }
        }
    }
}