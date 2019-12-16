using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPhysicalLink : CIMPhysicalElement
    {
        protected CIMPhysicalLink()
        {
        }

        protected CIMPhysicalLink(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Double? Length
        {
            get
            {
                System.Double? result;
                this.GetProperty("Length", out result);
                return result;
            }
        }

        public System.Double? MaxLength
        {
            get
            {
                System.Double? result;
                this.GetProperty("MaxLength", out result);
                return result;
            }
        }

        public System.UInt16? MediaType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MediaType", out result);
                return result;
            }
        }

        public System.Boolean? Wired
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Wired", out result);
                return result;
            }
        }
    }
}