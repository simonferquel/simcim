using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Service : Win32BaseService
    {
        public Win32Service()
        {
        }

        public Win32Service(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CheckPoint
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CheckPoint", out result);
                return result;
            }
        }

        public System.Boolean? DelayedAutoStart
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DelayedAutoStart", out result);
                return result;
            }
        }

        public System.UInt32? ProcessId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessId", out result);
                return result;
            }
        }

        public System.UInt32? WaitHint
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WaitHint", out result);
                return result;
            }
        }

        public (System.UInt32 retval, Win32SecurityDescriptor outDescriptor) GetSecurityDescriptor()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetSecurityDescriptor", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (Win32SecurityDescriptor)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Descriptor"].Value));
        }

        public System.UInt32 SetSecurityDescriptor(Win32SecurityDescriptor inDescriptor)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Descriptor", inDescriptor.AsCimInstance(), inDescriptor == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetSecurityDescriptor", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public Win32WMISetting ResolveWin32WMIElementSettingSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_WMIElementSetting", "Win32_WMISetting", "Element", "Setting");
            return instances.Select(i => (Win32WMISetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32ServiceSpecification ResolveWin32ServiceSpecificationServiceCheck()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ServiceSpecificationService", "Win32_ServiceSpecification", "Element", "Check");
            return instances.Select(i => (Win32ServiceSpecification)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<Win32ComputerSystem> ResolveWin32SystemServicesGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemServices", "Win32_ComputerSystem", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32ComputerSystem)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}