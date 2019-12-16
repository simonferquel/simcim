using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMVideoBIOSElement : CIMSoftwareElement
    {
        protected CIMVideoBIOSElement()
        {
        }

        protected CIMVideoBIOSElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? IsShadowed
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsShadowed", out result);
                return result;
            }
        }
    }
}