using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMBIOSFeatureBIOSElements : CIMSoftwareFeatureSoftwareElements
    {
        protected CIMBIOSFeatureBIOSElements()
        {
        }

        protected CIMBIOSFeatureBIOSElements(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMBIOSFeature GroupComponent
        {
            get
            {
                CIMBIOSFeature result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new CIMBIOSElement PartComponent
        {
            get
            {
                CIMBIOSElement result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}