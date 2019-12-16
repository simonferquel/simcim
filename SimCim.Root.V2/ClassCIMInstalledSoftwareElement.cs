using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMInstalledSoftwareElement : GenericInfrastructureObject
    {
        protected CIMInstalledSoftwareElement()
        {
        }

        protected CIMInstalledSoftwareElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMSoftwareElement Software
        {
            get
            {
                CIMSoftwareElement result;
                this.GetInfrastructureObjectProperty("Software", out result);
                return result;
            }
        }

        public CIMComputerSystem System
        {
            get
            {
                CIMComputerSystem result;
                this.GetInfrastructureObjectProperty("System", out result);
                return result;
            }
        }
    }
}