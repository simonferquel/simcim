using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMVideoBIOSFeatureVideoBIOSElements : CIMSoftwareFeatureSoftwareElements
    {
        protected CIMVideoBIOSFeatureVideoBIOSElements()
        {
        }

        protected CIMVideoBIOSFeatureVideoBIOSElements(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMVideoBIOSFeature GroupComponent
        {
            get
            {
                CIMVideoBIOSFeature result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new CIMVideoBIOSElement PartComponent
        {
            get
            {
                CIMVideoBIOSElement result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}