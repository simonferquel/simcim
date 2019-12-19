using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetNat : MSFTNetSettingData
    {
        public MSFTNetNat()
        {
        }

        public MSFTNetNat(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? Active
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Active", out result);
                return result;
            }
        }

        public System.String ExternalIPInterfaceAddressPrefix
        {
            get
            {
                System.String result;
                this.GetProperty("ExternalIPInterfaceAddressPrefix", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExternalIPInterfaceAddressPrefix", value);
            }
        }

        public System.UInt32? IcmpQueryTimeout
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IcmpQueryTimeout", out result);
                return result;
            }

            set
            {
                this.SetProperty("IcmpQueryTimeout", value);
            }
        }

        public System.String InternalIPInterfaceAddressPrefix
        {
            get
            {
                System.String result;
                this.GetProperty("InternalIPInterfaceAddressPrefix", out result);
                return result;
            }

            set
            {
                this.SetProperty("InternalIPInterfaceAddressPrefix", value);
            }
        }

        public System.String InternalRoutingDomainId
        {
            get
            {
                System.String result;
                this.GetProperty("InternalRoutingDomainId", out result);
                return result;
            }

            set
            {
                this.SetProperty("InternalRoutingDomainId", value);
            }
        }

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
                return result;
            }
        }

        public System.UInt32? Store
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Store", out result);
                return result;
            }
        }

        public System.UInt32? TcpEstablishedConnectionTimeout
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TcpEstablishedConnectionTimeout", out result);
                return result;
            }

            set
            {
                this.SetProperty("TcpEstablishedConnectionTimeout", value);
            }
        }

        public System.Byte? TcpFilteringBehavior
        {
            get
            {
                System.Byte? result;
                this.GetProperty("TcpFilteringBehavior", out result);
                return result;
            }

            set
            {
                this.SetProperty("TcpFilteringBehavior", value);
            }
        }

        public System.UInt32? TcpTransientConnectionTimeout
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TcpTransientConnectionTimeout", out result);
                return result;
            }

            set
            {
                this.SetProperty("TcpTransientConnectionTimeout", value);
            }
        }

        public System.Byte? UdpFilteringBehavior
        {
            get
            {
                System.Byte? result;
                this.GetProperty("UdpFilteringBehavior", out result);
                return result;
            }

            set
            {
                this.SetProperty("UdpFilteringBehavior", value);
            }
        }

        public System.UInt32? UdpIdleSessionTimeout
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UdpIdleSessionTimeout", out result);
                return result;
            }

            set
            {
                this.SetProperty("UdpIdleSessionTimeout", value);
            }
        }

        public System.Byte? UdpInboundRefresh
        {
            get
            {
                System.Byte? result;
                this.GetProperty("UdpInboundRefresh", out result);
                return result;
            }

            set
            {
                this.SetProperty("UdpInboundRefresh", value);
            }
        }
    }
}