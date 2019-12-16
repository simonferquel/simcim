using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMBinarySensor : CIMSensor
    {
        protected CIMBinarySensor()
        {
        }

        protected CIMBinarySensor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? CurrentReading
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CurrentReading", out result);
                return result;
            }
        }

        public System.Boolean? ExpectedReading
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ExpectedReading", out result);
                return result;
            }
        }

        public System.String InterpretationOfFalse
        {
            get
            {
                System.String result;
                this.GetProperty("InterpretationOfFalse", out result);
                return result;
            }
        }

        public System.String InterpretationOfTrue
        {
            get
            {
                System.String result;
                this.GetProperty("InterpretationOfTrue", out result);
                return result;
            }
        }
    }
}