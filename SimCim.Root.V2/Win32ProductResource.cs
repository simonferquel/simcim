using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ProductResource : GenericInfrastructureObject
    {
        public Win32ProductResource()
        {
        }

        public Win32ProductResource(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32Product Product
        {
            get
            {
                Win32Product result;
                this.GetInfrastructureObjectProperty("Product", out result);
                return result;
            }
        }

        public Win32MSIResource Resource
        {
            get
            {
                Win32MSIResource result;
                this.GetInfrastructureObjectProperty("Resource", out result);
                return result;
            }
        }
    }
}