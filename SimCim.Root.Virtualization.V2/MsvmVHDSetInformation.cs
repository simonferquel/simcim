using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVHDSetInformation : GenericInfrastructureObject
    {
        public MsvmVHDSetInformation()
        {
        }

        public MsvmVHDSetInformation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] AllPaths
        {
            get
            {
                System.String[] result;
                this.GetProperty("AllPaths", out result);
                return result;
            }
        }

        public System.String Path
        {
            get
            {
                System.String result;
                this.GetProperty("Path", out result);
                return result;
            }
        }

        public System.String[] SnapshotIdList
        {
            get
            {
                System.String[] result;
                this.GetProperty("SnapshotIdList", out result);
                return result;
            }
        }
    }
}