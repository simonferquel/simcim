using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmGuestClusterInformation : GenericInfrastructureObject
    {
        public MsvmGuestClusterInformation()
        {
        }

        public MsvmGuestClusterInformation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ClusterId
        {
            get
            {
                System.String result;
                this.GetProperty("ClusterId", out result);
                return result;
            }
        }

        public System.UInt16? ClusterSize
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ClusterSize", out result);
                return result;
            }
        }

        public System.Boolean[] IsActiveActive
        {
            get
            {
                System.Boolean[] result;
                this.GetProperty("IsActiveActive", out result);
                return result;
            }
        }

        public System.Boolean[] IsClustered
        {
            get
            {
                System.Boolean[] result;
                this.GetProperty("IsClustered", out result);
                return result;
            }
        }

        public System.Boolean[] IsOnline
        {
            get
            {
                System.Boolean[] result;
                this.GetProperty("IsOnline", out result);
                return result;
            }
        }

        public System.Boolean[] IsOwned
        {
            get
            {
                System.Boolean[] result;
                this.GetProperty("IsOwned", out result);
                return result;
            }
        }

        public System.UInt64? LastResourceMoveTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LastResourceMoveTime", out result);
                return result;
            }
        }

        public System.String[] SharedVirtualHardDiskPaths
        {
            get
            {
                System.String[] result;
                this.GetProperty("SharedVirtualHardDiskPaths", out result);
                return result;
            }
        }

        public System.String[] SharedVirtualHardDisks
        {
            get
            {
                System.String[] result;
                this.GetProperty("SharedVirtualHardDisks", out result);
                return result;
            }
        }
    }
}