using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32MSIResource : CIMSetting
    {
        protected Win32MSIResource()
        {
        }

        protected Win32MSIResource(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32Product ResolveWin32ProductResourceProduct()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ProductResource", "Win32_Product", "Resource", "Product");
            return instances.Select(i => (Win32Product)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SoftwareElement ResolveWin32SoftwareElementResourceElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SoftwareElementResource", "Win32_SoftwareElement", "Setting", "Element");
            return instances.Select(i => (Win32SoftwareElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}