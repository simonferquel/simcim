using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSCSIInterface : CIMControlledBy
    {
        protected CIMSCSIInterface()
        {
        }

        protected CIMSCSIInterface(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMSCSIController Antecedent
        {
            get
            {
                CIMSCSIController result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public System.UInt32? SCSIRetries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SCSIRetries", out result);
                return result;
            }
        }

        public System.UInt32? SCSITimeouts
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SCSITimeouts", out result);
                return result;
            }
        }
    }
}