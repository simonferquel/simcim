using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public abstract class CIMSAAction : CIMPolicyAction
    {
        protected CIMSAAction()
        {
        }

        protected CIMSAAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? DoPacketLogging
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DoPacketLogging", out result);
                return result;
            }

            set
            {
                this.SetProperty("DoPacketLogging", value);
            }
        }
    }
}