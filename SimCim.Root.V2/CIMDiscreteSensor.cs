using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMDiscreteSensor : CIMSensor
    {
        protected CIMDiscreteSensor()
        {
        }

        protected CIMDiscreteSensor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] AcceptableValues
        {
            get
            {
                System.String[] result;
                this.GetProperty("AcceptableValues", out result);
                return result;
            }
        }

        public System.String CurrentReading
        {
            get
            {
                System.String result;
                this.GetProperty("CurrentReading", out result);
                return result;
            }
        }

        public System.String[] PossibleValues
        {
            get
            {
                System.String[] result;
                this.GetProperty("PossibleValues", out result);
                return result;
            }
        }
    }
}