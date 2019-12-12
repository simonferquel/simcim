using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMApplicationSystemSoftwareFeature : CIMSystemComponent
    {
        protected CIMApplicationSystemSoftwareFeature()
        {
        }

        protected CIMApplicationSystemSoftwareFeature(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMApplicationSystem GroupComponent
        {
            get
            {
                CIMApplicationSystem result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new CIMSoftwareFeature PartComponent
        {
            get
            {
                CIMSoftwareFeature result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}