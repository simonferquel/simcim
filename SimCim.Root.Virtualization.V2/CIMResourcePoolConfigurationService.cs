using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMResourcePoolConfigurationService : CIMService
    {
        protected CIMResourcePoolConfigurationService()
        {
        }

        protected CIMResourcePoolConfigurationService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, CIMResourcePool outPool) CreateResourcePool(System.String inElementName, IEnumerable<CIMLogicalDevice> inHostResources, System.String inResourceType)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ElementName", inElementName, CimType.String, inElementName == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("HostResources", inHostResources.AsCimInstance(), CimType.ReferenceArray, inHostResources == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ResourceType", inResourceType, CimType.String, inResourceType == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CreateResourcePool", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value), (CIMResourcePool)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Pool"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, CIMResourcePool outPool) CreateChildResourcePool(System.String inElementName, IEnumerable<CIMResourcePool> inParentPool, System.String[] inSettings)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ElementName", inElementName, CimType.String, inElementName == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ParentPool", inParentPool.AsCimInstance(), CimType.ReferenceArray, inParentPool == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("Settings", inSettings, CimType.StringArray, inSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CreateChildResourcePool", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value), (CIMResourcePool)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Pool"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) DeleteResourcePool(CIMResourcePool inPool)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Pool", inPool.AsCimInstance(), CimType.Reference, inPool == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DeleteResourcePool", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) AddResourcesToResourcePool(IEnumerable<CIMLogicalDevice> inHostResources, CIMResourcePool inPool)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("HostResources", inHostResources.AsCimInstance(), CimType.ReferenceArray, inHostResources == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("Pool", inPool.AsCimInstance(), CimType.Reference, inPool == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddResourcesToResourcePool", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RemoveResourcesFromResourcePool(IEnumerable<CIMLogicalDevice> inHostResources, CIMResourcePool inPool)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("HostResources", inHostResources.AsCimInstance(), CimType.ReferenceArray, inHostResources == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("Pool", inPool.AsCimInstance(), CimType.Reference, inPool == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveResourcesFromResourcePool", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ChangeParentResourcePool(CIMResourcePool inChildPool, IEnumerable<CIMResourcePool> inParentPool, System.String[] inSettings)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ChildPool", inChildPool.AsCimInstance(), CimType.Reference, inChildPool == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ParentPool", inParentPool.AsCimInstance(), CimType.ReferenceArray, inParentPool == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("Settings", inSettings, CimType.StringArray, inSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ChangeParentResourcePool", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }
    }
}