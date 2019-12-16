using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ProductSoftwareFeatures : CIMProductSoftwareFeatures
    {
        public Win32ProductSoftwareFeatures()
        {
        }

        public Win32ProductSoftwareFeatures(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32SoftwareFeature Component
        {
            get
            {
                Win32SoftwareFeature result;
                this.GetInfrastructureObjectProperty("Component", out result);
                return result;
            }
        }

        public new Win32Product Product
        {
            get
            {
                Win32Product result;
                this.GetInfrastructureObjectProperty("Product", out result);
                return result;
            }
        }
    }
}