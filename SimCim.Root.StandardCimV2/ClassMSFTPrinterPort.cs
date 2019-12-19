using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTPrinterPort : CIMManagedSystemElement
    {
        public MSFTPrinterPort()
        {
        }

        public MSFTPrinterPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ComputerName
        {
            get
            {
                System.String result;
                this.GetProperty("ComputerName", out result);
                return result;
            }
        }

        public System.String PortMonitor
        {
            get
            {
                System.String result;
                this.GetProperty("PortMonitor", out result);
                return result;
            }
        }
    }
}