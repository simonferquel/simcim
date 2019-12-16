using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMDeviceSoftware : CIMDependency
    {
        protected CIMDeviceSoftware()
        {
        }

        protected CIMDeviceSoftware(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMSoftwareElement Antecedent
        {
            get
            {
                CIMSoftwareElement result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMLogicalDevice Dependent
        {
            get
            {
                CIMLogicalDevice result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }

        public System.UInt16? Purpose
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Purpose", out result);
                return result;
            }
        }

        public System.String PurposeDescription
        {
            get
            {
                System.String result;
                this.GetProperty("PurposeDescription", out result);
                return result;
            }
        }
    }
}