using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTWsdPrinterPort : MSFTPrinterPort
    {
        public MSFTWsdPrinterPort()
        {
        }

        public MSFTWsdPrinterPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DeviceURL
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceURL", out result);
                return result;
            }
        }

        public System.String DeviceUUID
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceUUID", out result);
                return result;
            }
        }

        public System.UInt32? DiscoveryMethod
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DiscoveryMethod", out result);
                return result;
            }
        }
    }
}