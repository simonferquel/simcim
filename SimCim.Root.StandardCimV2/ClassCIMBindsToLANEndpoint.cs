using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class CIMBindsToLANEndpoint : CIMBindsTo
    {
        public CIMBindsToLANEndpoint()
        {
        }

        public CIMBindsToLANEndpoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMLANEndpoint Antecedent
        {
            get
            {
                CIMLANEndpoint result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public System.UInt16? FrameType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("FrameType", out result);
                return result;
            }

            set
            {
                this.SetProperty("FrameType", value);
            }
        }
    }
}