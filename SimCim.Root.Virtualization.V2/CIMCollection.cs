using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMCollection : CIMManagedElement
    {
        protected CIMCollection()
        {
        }

        protected CIMCollection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public IEnumerable<CIMManagedElement> ResolveCIMMemberOfCollectionMember()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_MemberOfCollection", "CIM_ManagedElement", "Collection", "Member");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<CIMCollectionOfMSEs> ResolveMsvmReferencePointOfVirtualSystemCollectionAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ReferencePointOfVirtualSystemCollection", "CIM_CollectionOfMSEs", "Dependent", "Antecedent");
            return instances.Select(i => (CIMCollectionOfMSEs)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<CIMCollectionOfMSEs> ResolveMsvmSnapshotOfVirtualSystemCollectionAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SnapshotOfVirtualSystemCollection", "CIM_CollectionOfMSEs", "Dependent", "Antecedent");
            return instances.Select(i => (CIMCollectionOfMSEs)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}