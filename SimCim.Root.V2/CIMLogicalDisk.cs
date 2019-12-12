using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMLogicalDisk : CIMStorageExtent
    {
        protected CIMLogicalDisk()
        {
        }

        protected CIMLogicalDisk(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? FreeSpace
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FreeSpace", out result);
                return result;
            }
        }

        public System.UInt64? Size
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Size", out result);
                return result;
            }
        }
    }
}