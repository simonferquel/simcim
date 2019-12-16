using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NetworkProtocol : CIMLogicalElement
    {
        public Win32NetworkProtocol()
        {
        }

        public Win32NetworkProtocol(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? ConnectionlessService
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ConnectionlessService", out result);
                return result;
            }
        }

        public System.Boolean? GuaranteesDelivery
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("GuaranteesDelivery", out result);
                return result;
            }
        }

        public System.Boolean? GuaranteesSequencing
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("GuaranteesSequencing", out result);
                return result;
            }
        }

        public System.UInt32? MaximumAddressSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumAddressSize", out result);
                return result;
            }
        }

        public System.UInt32? MaximumMessageSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumMessageSize", out result);
                return result;
            }
        }

        public System.Boolean? MessageOriented
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MessageOriented", out result);
                return result;
            }
        }

        public System.UInt32? MinimumAddressSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MinimumAddressSize", out result);
                return result;
            }
        }

        public System.Boolean? PseudoStreamOriented
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PseudoStreamOriented", out result);
                return result;
            }
        }

        public System.Boolean? SupportsBroadcasting
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsBroadcasting", out result);
                return result;
            }
        }

        public System.Boolean? SupportsConnectData
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsConnectData", out result);
                return result;
            }
        }

        public System.Boolean? SupportsDisconnectData
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsDisconnectData", out result);
                return result;
            }
        }

        public System.Boolean? SupportsEncryption
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsEncryption", out result);
                return result;
            }
        }

        public System.Boolean? SupportsExpeditedData
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsExpeditedData", out result);
                return result;
            }
        }

        public System.Boolean? SupportsFragmentation
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsFragmentation", out result);
                return result;
            }
        }

        public System.Boolean? SupportsGracefulClosing
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsGracefulClosing", out result);
                return result;
            }
        }

        public System.Boolean? SupportsGuaranteedBandwidth
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsGuaranteedBandwidth", out result);
                return result;
            }
        }

        public System.Boolean? SupportsMulticasting
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsMulticasting", out result);
                return result;
            }
        }

        public System.Boolean? SupportsQualityofService
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsQualityofService", out result);
                return result;
            }
        }
    }
}