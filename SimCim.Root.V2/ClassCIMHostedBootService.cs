using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMHostedBootService : CIMHostedService
    {
        protected CIMHostedBootService()
        {
        }

        protected CIMHostedBootService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMBootService Dependent
        {
            get
            {
                CIMBootService result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}