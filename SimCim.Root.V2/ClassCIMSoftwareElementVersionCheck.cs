using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSoftwareElementVersionCheck : CIMCheck
    {
        protected CIMSoftwareElementVersionCheck()
        {
        }

        protected CIMSoftwareElementVersionCheck(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String LowerSoftwareElementVersion
        {
            get
            {
                System.String result;
                this.GetProperty("LowerSoftwareElementVersion", out result);
                return result;
            }
        }

        public System.String SoftwareElementName
        {
            get
            {
                System.String result;
                this.GetProperty("SoftwareElementName", out result);
                return result;
            }
        }

        public System.UInt16? SoftwareElementStateDesired
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SoftwareElementStateDesired", out result);
                return result;
            }
        }

        public System.UInt16? TargetOperatingSystemDesired
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TargetOperatingSystemDesired", out result);
                return result;
            }
        }

        public System.String UpperSoftwareElementVersion
        {
            get
            {
                System.String result;
                this.GetProperty("UpperSoftwareElementVersion", out result);
                return result;
            }
        }
    }
}