using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SoftwareElementResource : Win32ManagedSystemElementResource
    {
        public Win32SoftwareElementResource()
        {
        }

        public Win32SoftwareElementResource(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32SoftwareElement Element
        {
            get
            {
                Win32SoftwareElement result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public Win32MSIResource Setting
        {
            get
            {
                Win32MSIResource result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}