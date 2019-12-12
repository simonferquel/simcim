using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersBluetoothDevice : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersBluetoothDevice()
        {
        }

        public Win32PerfFormattedDataCountersBluetoothDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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
    }
}