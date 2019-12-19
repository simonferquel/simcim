using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public abstract class CIMSANegotiationAction : CIMSAAction
    {
        protected CIMSANegotiationAction()
        {
        }

        protected CIMSANegotiationAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? IdleDurationSeconds
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IdleDurationSeconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("IdleDurationSeconds", value);
            }
        }

        public System.UInt64? MinLifetimeKilobytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MinLifetimeKilobytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("MinLifetimeKilobytes", value);
            }
        }

        public System.UInt64? MinLifetimeSeconds
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MinLifetimeSeconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("MinLifetimeSeconds", value);
            }
        }
    }
}