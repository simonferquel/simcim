using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmComputerSystemSummaryInformation : CIMElementView
    {
        public MsvmComputerSystemSummaryInformation()
        {
        }

        public MsvmComputerSystemSummaryInformation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMComputerSystem Antecedent
        {
            get
            {
                CIMComputerSystem result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new MsvmSummaryInformationBase Dependent
        {
            get
            {
                MsvmSummaryInformationBase result;
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