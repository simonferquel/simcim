using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMAssociatedProcessorMemory : CIMAssociatedMemory
    {
        protected CIMAssociatedProcessorMemory()
        {
        }

        protected CIMAssociatedProcessorMemory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMProcessor Dependent
        {
            get
            {
                CIMProcessor result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }

        public System.UInt32? BusSpeed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BusSpeed", out result);
                return result;
            }
        }
    }
}