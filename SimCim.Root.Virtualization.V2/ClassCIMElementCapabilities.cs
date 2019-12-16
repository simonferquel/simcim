using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMElementCapabilities : GenericInfrastructureObject
    {
        protected CIMElementCapabilities()
        {
        }

        protected CIMElementCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMCapabilities Capabilities
        {
            get
            {
                CIMCapabilities result;
                this.GetInfrastructureObjectProperty("Capabilities", out result);
                return result;
            }

            set
            {
                this.SetProperty("Capabilities", value);
            }
        }

        public System.UInt16[] Characteristics
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("Characteristics", out result);
                return result;
            }

            set
            {
                this.SetProperty("Characteristics", value);
            }
        }

        public CIMManagedElement ManagedElement
        {
            get
            {
                CIMManagedElement result;
                this.GetInfrastructureObjectProperty("ManagedElement", out result);
                return result;
            }

            set
            {
                this.SetProperty("ManagedElement", value);
            }
        }
    }
}