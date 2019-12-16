using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMChassis : CIMPhysicalFrame
    {
        protected CIMChassis()
        {
        }

        protected CIMChassis(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] ChassisTypes
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("ChassisTypes", out result);
                return result;
            }
        }

        public System.Int16? CurrentRequiredOrProduced
        {
            get
            {
                System.Int16? result;
                this.GetProperty("CurrentRequiredOrProduced", out result);
                return result;
            }
        }

        public System.UInt16? HeatGeneration
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("HeatGeneration", out result);
                return result;
            }
        }

        public System.UInt16? NumberOfPowerCords
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NumberOfPowerCords", out result);
                return result;
            }
        }

        public System.String[] TypeDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("TypeDescriptions", out result);
                return result;
            }
        }
    }
}