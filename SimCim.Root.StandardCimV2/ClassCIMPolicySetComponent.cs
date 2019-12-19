using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class CIMPolicySetComponent : CIMPolicyComponent
    {
        public CIMPolicySetComponent()
        {
        }

        public CIMPolicySetComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMPolicySet GroupComponent
        {
            get
            {
                CIMPolicySet result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupComponent", value);
            }
        }

        public new CIMPolicySet PartComponent
        {
            get
            {
                CIMPolicySet result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("PartComponent", value);
            }
        }

        public System.UInt16? Priority
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Priority", out result);
                return result;
            }

            set
            {
                this.SetProperty("Priority", value);
            }
        }
    }
}