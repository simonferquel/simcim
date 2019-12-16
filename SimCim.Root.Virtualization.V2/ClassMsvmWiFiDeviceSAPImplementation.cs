using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmWiFiDeviceSAPImplementation : CIMDeviceSAPImplementation
    {
        public MsvmWiFiDeviceSAPImplementation()
        {
        }

        public MsvmWiFiDeviceSAPImplementation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmWiFiPort Antecedent
        {
            get
            {
                MsvmWiFiPort result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new MsvmWiFiEndpoint Dependent
        {
            get
            {
                MsvmWiFiEndpoint result;
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