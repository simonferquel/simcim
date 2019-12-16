using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMBIOSElement : CIMSoftwareElement
    {
        protected CIMBIOSElement()
        {
        }

        protected CIMBIOSElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? PrimaryBIOS
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PrimaryBIOS", out result);
                return result;
            }
        }
    }
}