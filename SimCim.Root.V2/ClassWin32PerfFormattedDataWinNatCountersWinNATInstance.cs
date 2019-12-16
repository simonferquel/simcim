using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataWinNatCountersWinNATInstance : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataWinNatCountersWinNATInstance()
        {
        }

        public Win32PerfFormattedDataWinNatCountersWinNATInstance(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? TCPPortsAvailable
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TCPPortsAvailable", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPPortsAvailable", value);
            }
        }

        public System.UInt32? TCPPortsInUse
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TCPPortsInUse", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPPortsInUse", value);
            }
        }

        public System.UInt32? UDPPortsAvailable
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UDPPortsAvailable", out result);
                return result;
            }

            set
            {
                this.SetProperty("UDPPortsAvailable", value);
            }
        }

        public System.UInt32? UDPPortsInUse
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UDPPortsInUse", out result);
                return result;
            }

            set
            {
                this.SetProperty("UDPPortsInUse", value);
            }
        }
    }
}