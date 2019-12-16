using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Patch : Win32MSIResource
    {
        public Win32Patch()
        {
        }

        public Win32Patch(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Attributes
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Attributes", out result);
                return result;
            }
        }

        public System.String File
        {
            get
            {
                System.String result;
                this.GetProperty("File", out result);
                return result;
            }
        }

        public System.UInt32? PatchSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PatchSize", out result);
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

        public System.Int16 Sequence
        {
            get
            {
                System.Int16 result;
                this.GetProperty("Sequence", out result);
                return result;
            }
        }
    }
}