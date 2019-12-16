using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMController : CIMLogicalDevice
    {
        protected CIMController()
        {
        }

        protected CIMController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? MaxNumberControlled
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxNumberControlled", out result);
                return result;
            }
        }

        public System.UInt16? ProtocolSupported
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ProtocolSupported", out result);
                return result;
            }
        }

        public System.DateTime? TimeOfLastReset
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeOfLastReset", out result);
                return result;
            }
        }
    }
}