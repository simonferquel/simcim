using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersBluetoothRadio : Win32PerfRawData
    {
        public Win32PerfRawDataCountersBluetoothRadio()
        {
        }

        public Win32PerfRawDataCountersBluetoothRadio(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ACLflusheventsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ACLflusheventsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ACLflusheventsPersec", value);
            }
        }

        public System.UInt32? ClassicACLbytesreadPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ClassicACLbytesreadPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ClassicACLbytesreadPersec", value);
            }
        }

        public System.UInt32? ClassicACLbyteswrittenPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ClassicACLbyteswrittenPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ClassicACLbyteswrittenPersec", value);
            }
        }

        public System.UInt32? ClassicACLConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ClassicACLConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("ClassicACLConnections", value);
            }
        }

        public System.UInt32? ClassicACLwritecredits
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ClassicACLwritecredits", out result);
                return result;
            }

            set
            {
                this.SetProperty("ClassicACLwritecredits", value);
            }
        }

        public System.UInt32? InquiryScanDutyCyclePercent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InquiryScanDutyCyclePercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("InquiryScanDutyCyclePercent", value);
            }
        }

        public System.UInt32? InquiryScanInterval
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InquiryScanInterval", out result);
                return result;
            }

            set
            {
                this.SetProperty("InquiryScanInterval", value);
            }
        }

        public System.UInt32? InquiryScanWindow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InquiryScanWindow", out result);
                return result;
            }

            set
            {
                this.SetProperty("InquiryScanWindow", value);
            }
        }

        public System.UInt32? LEACLbytesreadPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LEACLbytesreadPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LEACLbytesreadPersec", value);
            }
        }

        public System.UInt32? LEACLbyteswrittenPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LEACLbyteswrittenPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("LEACLbyteswrittenPersec", value);
            }
        }

        public System.UInt32? LEACLConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LEACLConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("LEACLConnections", value);
            }
        }

        public System.UInt32? LEACLwritecredits
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LEACLwritecredits", out result);
                return result;
            }

            set
            {
                this.SetProperty("LEACLwritecredits", value);
            }
        }

        public System.UInt32? LEScanDutyCyclePercentCodedPhy
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LEScanDutyCyclePercentCodedPhy", out result);
                return result;
            }

            set
            {
                this.SetProperty("LEScanDutyCyclePercentCodedPhy", value);
            }
        }

        public System.UInt32? LEScanDutyCyclePercentUncoded1MPhy
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LEScanDutyCyclePercentUncoded1MPhy", out result);
                return result;
            }

            set
            {
                this.SetProperty("LEScanDutyCyclePercentUncoded1MPhy", value);
            }
        }

        public System.UInt32? LEScanIntervalCodedPhy
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LEScanIntervalCodedPhy", out result);
                return result;
            }

            set
            {
                this.SetProperty("LEScanIntervalCodedPhy", value);
            }
        }

        public System.UInt32? LEScanIntervalUncoded1MPhy
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LEScanIntervalUncoded1MPhy", out result);
                return result;
            }

            set
            {
                this.SetProperty("LEScanIntervalUncoded1MPhy", value);
            }
        }

        public System.UInt32? LEScanWindowCodedPhy
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LEScanWindowCodedPhy", out result);
                return result;
            }

            set
            {
                this.SetProperty("LEScanWindowCodedPhy", value);
            }
        }

        public System.UInt32? LEScanWindowUncoded1MPhy
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LEScanWindowUncoded1MPhy", out result);
                return result;
            }

            set
            {
                this.SetProperty("LEScanWindowUncoded1MPhy", value);
            }
        }

        public System.UInt32? PageScanDutyCyclePercent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PageScanDutyCyclePercent", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageScanDutyCyclePercent", value);
            }
        }

        public System.UInt32? PageScanInterval
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PageScanInterval", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageScanInterval", value);
            }
        }

        public System.UInt32? PageScanWindow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PageScanWindow", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageScanWindow", value);
            }
        }

        public System.UInt32? SCObytesreadPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SCObytesreadPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SCObytesreadPersec", value);
            }
        }

        public System.UInt32? SCObyteswrittenPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SCObyteswrittenPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SCObyteswrittenPersec", value);
            }
        }

        public System.UInt32? SCOConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SCOConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("SCOConnections", value);
            }
        }

        public System.UInt32? SidebandSCOConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SidebandSCOConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("SidebandSCOConnections", value);
            }
        }
    }
}