using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualSystemReferencePoint : CIMManagedElement
    {
        public MsvmVirtualSystemReferencePoint()
        {
        }

        public MsvmVirtualSystemReferencePoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? ConsistencyLevel
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ConsistencyLevel", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConsistencyLevel", value);
            }
        }

        public System.Boolean? HasAssociatedData
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HasAssociatedData", out result);
                return result;
            }

            set
            {
                this.SetProperty("HasAssociatedData", value);
            }
        }

        public System.UInt16? ReferencePointType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ReferencePointType", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReferencePointType", value);
            }
        }

        public System.String[] ResilientChangeTrackingIdentifiers
        {
            get
            {
                System.String[] result;
                this.GetProperty("ResilientChangeTrackingIdentifiers", out result);
                return result;
            }
        }

        public System.String[] VirtualDiskIdentifiers
        {
            get
            {
                System.String[] result;
                this.GetProperty("VirtualDiskIdentifiers", out result);
                return result;
            }
        }

        public System.String VirtualSystemIdentifier
        {
            get
            {
                System.String result;
                this.GetProperty("VirtualSystemIdentifier", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualSystemIdentifier", value);
            }
        }
    }
}