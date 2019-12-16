using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSerialInterface : CIMControlledBy
    {
        protected CIMSerialInterface()
        {
        }

        protected CIMSerialInterface(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMSerialController Antecedent
        {
            get
            {
                CIMSerialController result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public System.UInt16? FlowControlInfo
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("FlowControlInfo", out result);
                return result;
            }
        }

        public System.UInt16? NumberOfStopBits
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NumberOfStopBits", out result);
                return result;
            }
        }

        public System.UInt16? ParityInfo
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ParityInfo", out result);
                return result;
            }
        }
    }
}