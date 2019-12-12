using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMSCSIProtocolController : CIMProtocolController
    {
        protected CIMSCSIProtocolController()
        {
        }

        protected CIMSCSIProtocolController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? NameFormat
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NameFormat", out result);
                return result;
            }

            set
            {
                this.SetProperty("NameFormat", value);
            }
        }

        public System.String OtherNameFormat
        {
            get
            {
                System.String result;
                this.GetProperty("OtherNameFormat", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherNameFormat", value);
            }
        }
    }
}