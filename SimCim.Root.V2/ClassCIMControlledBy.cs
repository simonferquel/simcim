using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMControlledBy : CIMDeviceConnection
    {
        protected CIMControlledBy()
        {
        }

        protected CIMControlledBy(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMController Antecedent
        {
            get
            {
                CIMController result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public System.UInt16? AccessState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AccessState", out result);
                return result;
            }
        }

        public System.UInt32? NumberOfHardResets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfHardResets", out result);
                return result;
            }
        }

        public System.UInt32? NumberOfSoftResets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfSoftResets", out result);
                return result;
            }
        }
    }
}