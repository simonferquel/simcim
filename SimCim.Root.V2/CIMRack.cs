using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMRack : CIMPhysicalFrame
    {
        protected CIMRack()
        {
        }

        protected CIMRack(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CountryDesignation
        {
            get
            {
                System.String result;
                this.GetProperty("CountryDesignation", out result);
                return result;
            }
        }

        public System.UInt16? TypeOfRack
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TypeOfRack", out result);
                return result;
            }
        }
    }
}