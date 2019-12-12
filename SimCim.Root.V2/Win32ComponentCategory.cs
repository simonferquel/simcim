using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ComponentCategory : CIMLogicalElement
    {
        public Win32ComponentCategory()
        {
        }

        public Win32ComponentCategory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CategoryId
        {
            get
            {
                System.String result;
                this.GetProperty("CategoryId", out result);
                return result;
            }
        }

        public Win32ClassicCOMClass ResolveWin32ImplementedCategoryComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ImplementedCategory", "Win32_ClassicCOMClass", "Category", "Component");
            return instances.Select(i => (Win32ClassicCOMClass)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}