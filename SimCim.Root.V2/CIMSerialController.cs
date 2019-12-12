using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSerialController : CIMController
    {
        protected CIMSerialController()
        {
        }

        protected CIMSerialController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] Capabilities
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("Capabilities", out result);
                return result;
            }
        }

        public System.String[] CapabilityDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("CapabilityDescriptions", out result);
                return result;
            }
        }

        public System.UInt32? MaxBaudRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxBaudRate", out result);
                return result;
            }
        }
    }
}