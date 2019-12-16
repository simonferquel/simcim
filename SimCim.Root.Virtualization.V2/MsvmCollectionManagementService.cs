using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmCollectionManagementService : CIMService
    {
        public MsvmCollectionManagementService()
        {
        }

        public MsvmCollectionManagementService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMCollectionOfMSEs outDefinedCollection, CIMConcreteJob outJob) DefineCollection(System.String inId, System.String inName, System.UInt16? inType)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Id", inId, CimType.String, inId == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            if (inType.HasValue)
                parameters.Add(CimMethodParameter.Create("Type", inType.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Type", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DefineCollection", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMCollectionOfMSEs)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["DefinedCollection"].Value), (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) DestroyCollection(CIMCollectionOfMSEs inCollection)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Collection", inCollection.AsCimInstance(), CimType.Reference, inCollection == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DestroyCollection", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RenameCollection(CIMCollectionOfMSEs inCollection, System.String inNewName)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Collection", inCollection.AsCimInstance(), CimType.Reference, inCollection == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("NewName", inNewName, CimType.String, inNewName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RenameCollection", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) AddMember(CIMCollectionOfMSEs inCollection, CIMManagedElement inMember)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Collection", inCollection.AsCimInstance(), CimType.Reference, inCollection == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("Member", inMember.AsCimInstance(), CimType.Reference, inMember == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddMember", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RemoveMember(CIMCollectionOfMSEs inCollection, CIMManagedElement inMember)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Collection", inCollection.AsCimInstance(), CimType.Reference, inCollection == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("Member", inMember.AsCimInstance(), CimType.Reference, inMember == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveMember", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RemoveMemberById(System.String inCollectionId, CIMManagedElement inMember)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("CollectionId", inCollectionId, CimType.String, inCollectionId == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("Member", inMember.AsCimInstance(), CimType.Reference, inMember == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveMemberById", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }
    }
}