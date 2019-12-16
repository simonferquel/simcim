using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Group : Win32Account
    {
        public Win32Group()
        {
        }

        public Win32Group(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32 Rename(System.String inName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Rename", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public IEnumerable<Win32NTDomain> ResolveWin32GroupInDomainGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_GroupInDomain", "Win32_NTDomain", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32NTDomain)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<Win32Account> ResolveWin32GroupUserPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_GroupUser", "Win32_Account", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32Account)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}