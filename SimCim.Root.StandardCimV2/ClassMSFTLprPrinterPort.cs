using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTLprPrinterPort : MSFTPrinterPort
    {
        public MSFTLprPrinterPort()
        {
        }

        public MSFTLprPrinterPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String HostName
        {
            get
            {
                System.String result;
                this.GetProperty("HostName", out result);
                return result;
            }
        }

        public System.String PrinterName
        {
            get
            {
                System.String result;
                this.GetProperty("PrinterName", out result);
                return result;
            }
        }
    }
}