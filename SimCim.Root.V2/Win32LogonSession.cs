using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LogonSession : Win32Session
    {
        public Win32LogonSession()
        {
        }

        public Win32LogonSession(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AuthenticationPackage
        {
            get
            {
                System.String result;
                this.GetProperty("AuthenticationPackage", out result);
                return result;
            }

            set
            {
                this.SetProperty("AuthenticationPackage", value);
            }
        }

        public System.String LogonId
        {
            get
            {
                System.String result;
                this.GetProperty("LogonId", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogonId", value);
            }
        }

        public System.UInt32? LogonType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogonType", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogonType", value);
            }
        }

        public Win32MappedLogicalDisk ResolveWin32LogonSessionMappedDiskDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogonSessionMappedDisk", "Win32_MappedLogicalDisk", "Antecedent", "Dependent");
            return instances.Select(i => (Win32MappedLogicalDisk)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32Process ResolveWin32SessionProcessDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SessionProcess", "Win32_Process", "Antecedent", "Dependent");
            return instances.Select(i => (Win32Process)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32Account ResolveWin32LoggedOnUserAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LoggedOnUser", "Win32_Account", "Dependent", "Antecedent");
            return instances.Select(i => (Win32Account)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}