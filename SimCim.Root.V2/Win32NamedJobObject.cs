using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NamedJobObject : CIMCollectionOfMSEs
    {
        public Win32NamedJobObject()
        {
        }

        public Win32NamedJobObject(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BasicUIRestrictions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BasicUIRestrictions", out result);
                return result;
            }
        }

        public Win32NamedJobObjectActgInfo ResolveWin32NamedJobObjectStatisticsStats()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_NamedJobObjectStatistics", "Win32_NamedJobObjectActgInfo", "Collection", "Stats");
            return instances.Select(i => (Win32NamedJobObjectActgInfo)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<Win32Process> ResolveWin32NamedJobObjectProcessMember()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_NamedJobObjectProcess", "Win32_Process", "Collection", "Member");
            return instances.Select(i => (Win32Process)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public Win32NamedJobObjectLimitSetting ResolveWin32NamedJobObjectLimitSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_NamedJobObjectLimit", "Win32_NamedJobObjectLimitSetting", "Collection", "Setting");
            return instances.Select(i => (Win32NamedJobObjectLimitSetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32NamedJobObjectSecLimitSetting ResolveWin32NamedJobObjectSecLimitSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_NamedJobObjectSecLimit", "Win32_NamedJobObjectSecLimitSetting", "Collection", "Setting");
            return instances.Select(i => (Win32NamedJobObjectSecLimitSetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}