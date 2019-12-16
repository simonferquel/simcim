using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataTcpipUDPv6 : Win32PerfRawData
    {
        public Win32PerfRawDataTcpipUDPv6()
        {
        }

        public Win32PerfRawDataTcpipUDPv6(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? DatagramsNoPortPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsNoPortPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsNoPortPersec", value);
            }
        }

        public System.UInt32? DatagramsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsPersec", value);
            }
        }

        public System.UInt32? DatagramsReceivedErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsReceivedErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsReceivedErrors", value);
            }
        }

        public System.UInt32? DatagramsReceivedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsReceivedPersec", value);
            }
        }

        public System.UInt32? DatagramsSentPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsSentPersec", value);
            }
        }
    }
}