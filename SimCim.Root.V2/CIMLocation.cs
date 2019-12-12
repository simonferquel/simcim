using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMLocation : GenericInfrastructureObject
    {
        protected CIMLocation()
        {
        }

        protected CIMLocation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Address
        {
            get
            {
                System.String result;
                this.GetProperty("Address", out result);
                return result;
            }
        }

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
                return result;
            }
        }

        public System.String PhysicalPosition
        {
            get
            {
                System.String result;
                this.GetProperty("PhysicalPosition", out result);
                return result;
            }
        }
    }
}