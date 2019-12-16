using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMCollectionOfSensors : CIMComponent
    {
        protected CIMCollectionOfSensors()
        {
        }

        protected CIMCollectionOfSensors(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMMultiStateSensor GroupComponent
        {
            get
            {
                CIMMultiStateSensor result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new CIMBinarySensor PartComponent
        {
            get
            {
                CIMBinarySensor result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}