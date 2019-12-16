using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SoftwareFeatureAction : GenericInfrastructureObject
    {
        public Win32SoftwareFeatureAction()
        {
        }

        public Win32SoftwareFeatureAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMAction Action
        {
            get
            {
                CIMAction result;
                this.GetInfrastructureObjectProperty("Action", out result);
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