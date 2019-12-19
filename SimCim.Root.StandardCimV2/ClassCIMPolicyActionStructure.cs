using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public abstract class CIMPolicyActionStructure : CIMPolicyComponent
    {
        protected CIMPolicyActionStructure()
        {
        }

        protected CIMPolicyActionStructure(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMPolicyAction PartComponent
        {
            get
            {
                CIMPolicyAction result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("PartComponent", value);
            }
        }

        public System.UInt16? ActionOrder
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ActionOrder", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActionOrder", value);
            }
        }
    }
}