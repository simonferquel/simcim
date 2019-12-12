using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmReferencePointCollection : CIMCollection
    {
        public MsvmReferencePointCollection()
        {
        }

        public MsvmReferencePointCollection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CollectionID
        {
            get
            {
                System.String result;
                this.GetProperty("CollectionID", out result);
                return result;
            }

            set
            {
                this.SetProperty("CollectionID", value);
            }
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

        public System.Boolean? HasAssociatedLog
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HasAssociatedLog", out result);
                return result;
            }

            set
            {
                this.SetProperty("HasAssociatedLog", value);
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

        public System.String VirtualSystemCollectionId
        {
            get
            {
                System.String result;
                this.GetProperty("VirtualSystemCollectionId", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualSystemCollectionId", value);
            }
        }

        public IEnumerable<MsvmVirtualSystemReferencePoint> ResolveMsvmCollectedReferencePointsMember()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_CollectedReferencePoints", "Msvm_VirtualSystemReferencePoint", "Collection", "Member");
            return instances.Select(i => (MsvmVirtualSystemReferencePoint)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}