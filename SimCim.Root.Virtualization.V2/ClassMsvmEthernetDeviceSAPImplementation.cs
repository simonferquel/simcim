using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetDeviceSAPImplementation : CIMDeviceSAPImplementation
    {
        public MsvmEthernetDeviceSAPImplementation()
        {
        }

        public MsvmEthernetDeviceSAPImplementation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMEthernetPort Antecedent
        {
            get
            {
                CIMEthernetPort result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new MsvmLANEndpoint Dependent
        {
            get
            {
                MsvmLANEndpoint result;
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