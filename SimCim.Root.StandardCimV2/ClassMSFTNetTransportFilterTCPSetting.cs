using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetTransportFilterTCPSetting : CIMDependency
    {
        public MSFTNetTransportFilterTCPSetting()
        {
        }

        public MSFTNetTransportFilterTCPSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetTransportFilter Antecedent
        {
            get
            {
                MSFTNetTransportFilter result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new MSFTNetTCPSetting Dependent
        {
            get
            {
                MSFTNetTCPSetting result;
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