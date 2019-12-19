using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTTcpIpPrinterPort : MSFTPrinterPort
    {
        public MSFTTcpIpPrinterPort()
        {
        }

        public MSFTTcpIpPrinterPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? LprByteCounting
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("LprByteCounting", out result);
                return result;
            }
        }

        public System.String LprQueueName
        {
            get
            {
                System.String result;
                this.GetProperty("LprQueueName", out result);
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

        public System.String PrinterHostAddress
        {
            get
            {
                System.String result;
                this.GetProperty("PrinterHostAddress", out result);
                return result;
            }
        }

        public System.String PrinterHostIP
        {
            get
            {
                System.String result;
                this.GetProperty("PrinterHostIP", out result);
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

        public System.String SNMPCommunity
        {
            get
            {
                System.String result;
                this.GetProperty("SNMPCommunity", out result);
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

        public System.UInt32? SNMPIndex
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SNMPIndex", out result);
                return result;
            }
        }
    }
}