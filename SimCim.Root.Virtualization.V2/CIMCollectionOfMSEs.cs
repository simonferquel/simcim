using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMCollectionOfMSEs : CIMCollection
    {
        protected CIMCollectionOfMSEs()
        {
        }

        protected CIMCollectionOfMSEs(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public IEnumerable<CIMManagedSystemElement> ResolveCIMCollectedMSEsMember()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_CollectedMSEs", "CIM_ManagedSystemElement", "Collection", "Member");
            return instances.Select(i => (CIMManagedSystemElement)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<MsvmManagementCollection> ResolveMsvmCollectedCollectionsCollection()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_CollectedCollections", "Msvm_ManagementCollection", "Member", "Collection");
            return instances.Select(i => (MsvmManagementCollection)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<CIMCollection> ResolveMsvmReferencePointOfVirtualSystemCollectionDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ReferencePointOfVirtualSystemCollection", "CIM_Collection", "Antecedent", "Dependent");
            return instances.Select(i => (CIMCollection)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<CIMCollection> ResolveMsvmSnapshotOfVirtualSystemCollectionDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SnapshotOfVirtualSystemCollection", "CIM_Collection", "Antecedent", "Dependent");
            return instances.Select(i => (CIMCollection)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}