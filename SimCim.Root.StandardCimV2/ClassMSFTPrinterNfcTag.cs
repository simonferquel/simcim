using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTPrinterNfcTag : GenericInfrastructureObject
    {
        public MSFTPrinterNfcTag()
        {
        }

        public MSFTPrinterNfcTag(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Locked
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Locked", out result);
                return result;
            }

            set
            {
                this.SetProperty("Locked", value);
            }
        }

        public System.String[] SharePath
        {
            get
            {
                System.String[] result;
                this.GetProperty("SharePath", out result);
                return result;
            }

            set
            {
                this.SetProperty("SharePath", value);
            }
        }

        public System.String[] WsdAddress
        {
            get
            {
                System.String[] result;
                this.GetProperty("WsdAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("WsdAddress", value);
            }
        }
    }
}