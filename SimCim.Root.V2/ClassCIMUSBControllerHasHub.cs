using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class CIMUSBControllerHasHub : CIMControlledBy
    {
        public CIMUSBControllerHasHub()
        {
        }

        public CIMUSBControllerHasHub(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMUSBController Antecedent
        {
            get
            {
                CIMUSBController result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMUSBHub Dependent
        {
            get
            {
                CIMUSBHub result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}