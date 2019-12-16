using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32BaseService : CIMService
    {
        protected Win32BaseService()
        {
        }

        protected Win32BaseService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AcceptPause
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AcceptPause", out result);
                return result;
            }
        }

        public System.Boolean? AcceptStop
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AcceptStop", out result);
                return result;
            }
        }

        public System.Boolean? DesktopInteract
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DesktopInteract", out result);
                return result;
            }
        }

        public System.String DisplayName
        {
            get
            {
                System.String result;
                this.GetProperty("DisplayName", out result);
                return result;
            }
        }

        public System.String ErrorControl
        {
            get
            {
                System.String result;
                this.GetProperty("ErrorControl", out result);
                return result;
            }
        }

        public System.UInt32? ExitCode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExitCode", out result);
                return result;
            }
        }

        public System.String PathName
        {
            get
            {
                System.String result;
                this.GetProperty("PathName", out result);
                return result;
            }
        }

        public System.UInt32? ServiceSpecificExitCode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ServiceSpecificExitCode", out result);
                return result;
            }
        }

        public System.String ServiceType
        {
            get
            {
                System.String result;
                this.GetProperty("ServiceType", out result);
                return result;
            }
        }

        public System.String StartName
        {
            get
            {
                System.String result;
                this.GetProperty("StartName", out result);
                return result;
            }
        }

        public System.String State
        {
            get
            {
                System.String result;
                this.GetProperty("State", out result);
                return result;
            }

            set
            {
                this.SetProperty("State", value);
            }
        }

        public System.UInt32? TagId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TagId", out result);
                return result;
            }
        }

        public System.UInt32 PauseService()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "PauseService", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ResumeService()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ResumeService", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 InterrogateService()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "InterrogateService", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 UserControlService(System.Byte? inControlCode)
        {
            var parameters = new CimMethodParametersCollection();
            if (inControlCode.HasValue)
                parameters.Add(CimMethodParameter.Create("ControlCode", inControlCode.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "UserControlService", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Create(System.Boolean? inDesktopInteract, System.String inDisplayName, System.Byte? inErrorControl, System.String inLoadOrderGroup, System.String[] inLoadOrderGroupDependencies, System.String inName, System.String inPathName, System.String[] inServiceDependencies, System.Byte? inServiceType, System.String inStartMode, System.String inStartName, System.String inStartPassword)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDesktopInteract.HasValue)
                parameters.Add(CimMethodParameter.Create("DesktopInteract", inDesktopInteract.Value, CimFlags.None));
            if (inDisplayName != null)
                parameters.Add(CimMethodParameter.Create("DisplayName", inDisplayName, CimType.String, inDisplayName == null ? CimFlags.NullValue : CimFlags.None));
            if (inErrorControl.HasValue)
                parameters.Add(CimMethodParameter.Create("ErrorControl", inErrorControl.Value, CimFlags.None));
            if (inLoadOrderGroup != null)
                parameters.Add(CimMethodParameter.Create("LoadOrderGroup", inLoadOrderGroup, CimType.String, inLoadOrderGroup == null ? CimFlags.NullValue : CimFlags.None));
            if (inLoadOrderGroupDependencies != null)
                parameters.Add(CimMethodParameter.Create("LoadOrderGroupDependencies", inLoadOrderGroupDependencies, CimType.StringArray, inLoadOrderGroupDependencies == null ? CimFlags.NullValue : CimFlags.None));
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            if (inPathName != null)
                parameters.Add(CimMethodParameter.Create("PathName", inPathName, CimType.String, inPathName == null ? CimFlags.NullValue : CimFlags.None));
            if (inServiceDependencies != null)
                parameters.Add(CimMethodParameter.Create("ServiceDependencies", inServiceDependencies, CimType.StringArray, inServiceDependencies == null ? CimFlags.NullValue : CimFlags.None));
            if (inServiceType.HasValue)
                parameters.Add(CimMethodParameter.Create("ServiceType", inServiceType.Value, CimFlags.None));
            if (inStartMode != null)
                parameters.Add(CimMethodParameter.Create("StartMode", inStartMode, CimType.String, inStartMode == null ? CimFlags.NullValue : CimFlags.None));
            if (inStartName != null)
                parameters.Add(CimMethodParameter.Create("StartName", inStartName, CimType.String, inStartName == null ? CimFlags.NullValue : CimFlags.None));
            if (inStartPassword != null)
                parameters.Add(CimMethodParameter.Create("StartPassword", inStartPassword, CimType.String, inStartPassword == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Create", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Change(System.Boolean? inDesktopInteract, System.String inDisplayName, System.Byte? inErrorControl, System.String inLoadOrderGroup, System.String[] inLoadOrderGroupDependencies, System.String inPathName, System.String[] inServiceDependencies, System.Byte? inServiceType, System.String inStartMode, System.String inStartName, System.String inStartPassword)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDesktopInteract.HasValue)
                parameters.Add(CimMethodParameter.Create("DesktopInteract", inDesktopInteract.Value, CimFlags.None));
            if (inDisplayName != null)
                parameters.Add(CimMethodParameter.Create("DisplayName", inDisplayName, CimType.String, inDisplayName == null ? CimFlags.NullValue : CimFlags.None));
            if (inErrorControl.HasValue)
                parameters.Add(CimMethodParameter.Create("ErrorControl", inErrorControl.Value, CimFlags.None));
            if (inLoadOrderGroup != null)
                parameters.Add(CimMethodParameter.Create("LoadOrderGroup", inLoadOrderGroup, CimType.String, inLoadOrderGroup == null ? CimFlags.NullValue : CimFlags.None));
            if (inLoadOrderGroupDependencies != null)
                parameters.Add(CimMethodParameter.Create("LoadOrderGroupDependencies", inLoadOrderGroupDependencies, CimType.StringArray, inLoadOrderGroupDependencies == null ? CimFlags.NullValue : CimFlags.None));
            if (inPathName != null)
                parameters.Add(CimMethodParameter.Create("PathName", inPathName, CimType.String, inPathName == null ? CimFlags.NullValue : CimFlags.None));
            if (inServiceDependencies != null)
                parameters.Add(CimMethodParameter.Create("ServiceDependencies", inServiceDependencies, CimType.StringArray, inServiceDependencies == null ? CimFlags.NullValue : CimFlags.None));
            if (inServiceType.HasValue)
                parameters.Add(CimMethodParameter.Create("ServiceType", inServiceType.Value, CimFlags.None));
            if (inStartMode != null)
                parameters.Add(CimMethodParameter.Create("StartMode", inStartMode, CimType.String, inStartMode == null ? CimFlags.NullValue : CimFlags.None));
            if (inStartName != null)
                parameters.Add(CimMethodParameter.Create("StartName", inStartName, CimType.String, inStartName == null ? CimFlags.NullValue : CimFlags.None));
            if (inStartPassword != null)
                parameters.Add(CimMethodParameter.Create("StartPassword", inStartPassword, CimType.String, inStartPassword == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Change", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ChangeStartMode(System.String inStartMode)
        {
            var parameters = new CimMethodParametersCollection();
            if (inStartMode != null)
                parameters.Add(CimMethodParameter.Create("StartMode", inStartMode, CimType.String, inStartMode == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ChangeStartMode", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Delete()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Delete", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public Win32LoadOrderGroup ResolveWin32LoadOrderGroupServiceDependenciesAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LoadOrderGroupServiceDependencies", "Win32_LoadOrderGroup", "Dependent", "Antecedent");
            return instances.Select(i => (Win32LoadOrderGroup)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32BaseService ResolveWin32DependentServiceDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_DependentService", "Win32_BaseService", "Antecedent", "Dependent");
            return instances.Select(i => (Win32BaseService)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32BaseService ResolveWin32DependentServiceAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_DependentService", "Win32_BaseService", "Dependent", "Antecedent");
            return instances.Select(i => (Win32BaseService)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<Win32LoadOrderGroup> ResolveWin32LoadOrderGroupServiceMembersGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LoadOrderGroupServiceMembers", "Win32_LoadOrderGroup", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32LoadOrderGroup)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}