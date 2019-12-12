using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMNumericSensor : CIMSensor
    {
        protected CIMNumericSensor()
        {
        }

        protected CIMNumericSensor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Int32? Accuracy
        {
            get
            {
                System.Int32? result;
                this.GetProperty("Accuracy", out result);
                return result;
            }
        }

        public System.Int32? CurrentReading
        {
            get
            {
                System.Int32? result;
                this.GetProperty("CurrentReading", out result);
                return result;
            }
        }

        public System.Boolean? IsLinear
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsLinear", out result);
                return result;
            }
        }

        public System.Int32? LowerThresholdCritical
        {
            get
            {
                System.Int32? result;
                this.GetProperty("LowerThresholdCritical", out result);
                return result;
            }
        }

        public System.Int32? LowerThresholdFatal
        {
            get
            {
                System.Int32? result;
                this.GetProperty("LowerThresholdFatal", out result);
                return result;
            }
        }

        public System.Int32? LowerThresholdNonCritical
        {
            get
            {
                System.Int32? result;
                this.GetProperty("LowerThresholdNonCritical", out result);
                return result;
            }
        }

        public System.Int32? MaxReadable
        {
            get
            {
                System.Int32? result;
                this.GetProperty("MaxReadable", out result);
                return result;
            }
        }

        public System.Int32? MinReadable
        {
            get
            {
                System.Int32? result;
                this.GetProperty("MinReadable", out result);
                return result;
            }
        }

        public System.Int32? NominalReading
        {
            get
            {
                System.Int32? result;
                this.GetProperty("NominalReading", out result);
                return result;
            }
        }

        public System.Int32? NormalMax
        {
            get
            {
                System.Int32? result;
                this.GetProperty("NormalMax", out result);
                return result;
            }
        }

        public System.Int32? NormalMin
        {
            get
            {
                System.Int32? result;
                this.GetProperty("NormalMin", out result);
                return result;
            }
        }

        public System.UInt32? Resolution
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Resolution", out result);
                return result;
            }
        }

        public System.Int32? Tolerance
        {
            get
            {
                System.Int32? result;
                this.GetProperty("Tolerance", out result);
                return result;
            }
        }

        public System.Int32? UpperThresholdCritical
        {
            get
            {
                System.Int32? result;
                this.GetProperty("UpperThresholdCritical", out result);
                return result;
            }
        }

        public System.Int32? UpperThresholdFatal
        {
            get
            {
                System.Int32? result;
                this.GetProperty("UpperThresholdFatal", out result);
                return result;
            }
        }

        public System.Int32? UpperThresholdNonCritical
        {
            get
            {
                System.Int32? result;
                this.GetProperty("UpperThresholdNonCritical", out result);
                return result;
            }
        }
    }
}