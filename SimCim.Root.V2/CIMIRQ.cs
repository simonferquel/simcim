using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMIRQ : CIMSystemResource
    {
        protected CIMIRQ()
        {
        }

        protected CIMIRQ(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Availability
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Availability", out result);
                return result;
            }
        }

        public System.String CreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CreationClassName", out result);
                return result;
            }
        }

        public System.String CSCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CSCreationClassName", out result);
                return result;
            }
        }

        public System.String CSName
        {
            get
            {
                System.String result;
                this.GetProperty("CSName", out result);
                return result;
            }
        }

        public System.UInt32? IRQNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IRQNumber", out result);
                return result;
            }
        }

        public System.Boolean? Shareable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Shareable", out result);
                return result;
            }
        }

        public System.UInt16? TriggerLevel
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TriggerLevel", out result);
                return result;
            }
        }

        public System.UInt16? TriggerType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TriggerType", out result);
                return result;
            }
        }
    }
}