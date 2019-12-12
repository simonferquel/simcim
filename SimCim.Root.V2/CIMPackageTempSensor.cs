using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPackageTempSensor : CIMDependency
    {
        protected CIMPackageTempSensor()
        {
        }

        protected CIMPackageTempSensor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMTemperatureSensor Antecedent
        {
            get
            {
                CIMTemperatureSensor result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMPhysicalPackage Dependent
        {
            get
            {
                CIMPhysicalPackage result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}