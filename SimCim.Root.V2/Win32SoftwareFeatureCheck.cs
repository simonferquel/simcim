using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SoftwareFeatureCheck : GenericInfrastructureObject
    {
        public Win32SoftwareFeatureCheck()
        {
        }

        public Win32SoftwareFeatureCheck(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMCheck Check
        {
            get
            {
                CIMCheck result;
                this.GetInfrastructureObjectProperty("Check", out result);
                return result;
            }
        }

        public Win32SoftwareFeature Element
        {
            get
            {
                Win32SoftwareFeature result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }
    }
}