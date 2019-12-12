using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PatchPackage : Win32MSIResource
    {
        public Win32PatchPackage()
        {
        }

        public Win32PatchPackage(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String PatchID
        {
            get
            {
                System.String result;
                this.GetProperty("PatchID", out result);
                return result;
            }
        }

        public System.String ProductCode
        {
            get
            {
                System.String result;
                this.GetProperty("ProductCode", out result);
                return result;
            }
        }
    }
}