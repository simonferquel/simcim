using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMAssociatedSupplyCurrentSensor : CIMAssociatedSensor
    {
        protected CIMAssociatedSupplyCurrentSensor()
        {
        }

        protected CIMAssociatedSupplyCurrentSensor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMCurrentSensor Antecedent
        {
            get
            {
                CIMCurrentSensor result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMPowerSupply Dependent
        {
            get
            {
                CIMPowerSupply result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }

        public System.UInt16? MonitoringRange
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MonitoringRange", out result);
                return result;
            }
        }
    }
}