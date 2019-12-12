using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMLogicalElement : CIMManagedSystemElement
    {
        protected CIMLogicalElement()
        {
        }

        protected CIMLogicalElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMLogicalElement ResolveCIMLogicalIdentitySystemElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "CIM_LogicalIdentity", "CIM_LogicalElement", "SameElement", "SystemElement");
            return instances.Select(i => (CIMLogicalElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMLogicalElement ResolveCIMLogicalIdentitySameElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "CIM_LogicalIdentity", "CIM_LogicalElement", "SystemElement", "SameElement");
            return instances.Select(i => (CIMLogicalElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}