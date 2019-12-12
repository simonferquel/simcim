using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVHDSnapshotInformation : GenericInfrastructureObject
    {
        public MsvmVHDSnapshotInformation()
        {
        }

        public MsvmVHDSnapshotInformation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.DateTime? CreationTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("CreationTime", out result);
                return result;
            }
        }

        public System.String FilePath
        {
            get
            {
                System.String result;
                this.GetProperty("FilePath", out result);
                return result;
            }
        }

        public System.String[] ParentPathsList
        {
            get
            {
                System.String[] result;
                this.GetProperty("ParentPathsList", out result);
                return result;
            }
        }

        public System.String ResilientChangeTrackingId
        {
            get
            {
                System.String result;
                this.GetProperty("ResilientChangeTrackingId", out result);
                return result;
            }
        }

        public System.String SnapshotId
        {
            get
            {
                System.String result;
                this.GetProperty("SnapshotId", out result);
                return result;
            }
        }

        public System.String SnapshotPath
        {
            get
            {
                System.String result;
                this.GetProperty("SnapshotPath", out result);
                return result;
            }
        }
    }
}