using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTDNSClientServerAddress : CIMRemoteServiceAccessPoint
    {
        public MSFTDNSClientServerAddress()
        {
        }

        public MSFTDNSClientServerAddress(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AddressFamily
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AddressFamily", out result);
                return result;
            }
        }

        public System.String InterfaceAlias
        {
            get
            {
                System.String result;
                this.GetProperty("InterfaceAlias", out result);
                return result;
            }
        }

        public System.UInt32? InterfaceIndex
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterfaceIndex", out result);
                return result;
            }
        }

        public System.String[] ServerAddresses
        {
            get
            {
                System.String[] result;
                this.GetProperty("ServerAddresses", out result);
                return result;
            }
        }
    }
}