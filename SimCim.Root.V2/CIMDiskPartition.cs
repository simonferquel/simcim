using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMDiskPartition : CIMStorageExtent
    {
        protected CIMDiskPartition()
        {
        }

        protected CIMDiskPartition(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Bootable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Bootable", out result);
                return result;
            }
        }

        public System.Boolean? PrimaryPartition
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PrimaryPartition", out result);
                return result;
            }
        }
    }
}