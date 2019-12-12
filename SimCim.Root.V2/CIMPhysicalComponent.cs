using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPhysicalComponent : CIMPhysicalElement
    {
        protected CIMPhysicalComponent()
        {
        }

        protected CIMPhysicalComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? HotSwappable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HotSwappable", out result);
                return result;
            }
        }

        public System.Boolean? Removable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Removable", out result);
                return result;
            }
        }

        public System.Boolean? Replaceable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Replaceable", out result);
                return result;
            }
        }
    }
}