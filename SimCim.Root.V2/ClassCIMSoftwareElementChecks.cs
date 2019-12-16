using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSoftwareElementChecks : GenericInfrastructureObject
    {
        protected CIMSoftwareElementChecks()
        {
        }

        protected CIMSoftwareElementChecks(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMCheck Check
        {
            get
            {
                CIMCheck result;
                this.GetInfrastructureObjectProperty("Check", out result);
                return result;
            }
        }

        public CIMSoftwareElement Element
        {
            get
            {
                CIMSoftwareElement result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public System.UInt16? Phase
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Phase", out result);
                return result;
            }
        }
    }
}