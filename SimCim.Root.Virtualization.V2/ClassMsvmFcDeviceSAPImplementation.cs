using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmFcDeviceSAPImplementation : CIMDeviceSAPImplementation
    {
        public MsvmFcDeviceSAPImplementation()
        {
        }

        public MsvmFcDeviceSAPImplementation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMFCPort Antecedent
        {
            get
            {
                CIMFCPort result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new MsvmFcEndpoint Dependent
        {
            get
            {
                MsvmFcEndpoint result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Dependent", value);
            }
        }
    }
}