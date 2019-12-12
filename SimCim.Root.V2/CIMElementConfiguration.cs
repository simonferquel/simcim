using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMElementConfiguration : GenericInfrastructureObject
    {
        protected CIMElementConfiguration()
        {
        }

        protected CIMElementConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMConfiguration Configuration
        {
            get
            {
                CIMConfiguration result;
                this.GetInfrastructureObjectProperty("Configuration", out result);
                return result;
            }
        }

        public CIMManagedSystemElement Element
        {
            get
            {
                CIMManagedSystemElement result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }
    }
}