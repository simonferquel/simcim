using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SoftwareFeatureSoftwareElements : CIMSoftwareFeatureSoftwareElements
    {
        public Win32SoftwareFeatureSoftwareElements()
        {
        }

        public Win32SoftwareFeatureSoftwareElements(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32SoftwareFeature GroupComponent
        {
            get
            {
                Win32SoftwareFeature result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new Win32SoftwareElement PartComponent
        {
            get
            {
                Win32SoftwareElement result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}