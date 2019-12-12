using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmElementConformsToProfile : CIMElementConformsToProfile
    {
        public MsvmElementConformsToProfile()
        {
        }

        public MsvmElementConformsToProfile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmComputerSystem ManagedElement
        {
            get
            {
                MsvmComputerSystem result;
                this.GetInfrastructureObjectProperty("ManagedElement", out result);
                return result;
            }

            set
            {
                this.SetProperty("ManagedElement", value);
            }
        }
    }
}