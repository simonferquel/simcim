using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32TCPIPPrinterPort : CIMServiceAccessPoint
    {
        public Win32TCPIPPrinterPort()
        {
        }

        public Win32TCPIPPrinterPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? ByteCount
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ByteCount", out result);
                return result;
            }
        }

        public System.String HostAddress
        {
            get
            {
                System.String result;
                this.GetProperty("HostAddress", out result);
                return result;
            }
        }

        public System.UInt32? PortNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PortNumber", out result);
                return result;
            }
        }

        public System.UInt32? Protocol
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Protocol", out result);
                return result;
            }
        }

        public System.String Queue
        {
            get
            {
                System.String result;
                this.GetProperty("Queue", out result);
                return result;
            }
        }

        public System.String SNMPCommunity
        {
            get
            {
                System.String result;
                this.GetProperty("SNMPCommunity", out result);
                return result;
            }
        }

        public System.UInt32? SNMPDevIndex
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SNMPDevIndex", out result);
                return result;
            }
        }

        public System.Boolean? SNMPEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SNMPEnabled", out result);
                return result;
            }
        }
    }
}