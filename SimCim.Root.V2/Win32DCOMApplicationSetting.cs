using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DCOMApplicationSetting : Win32COMSetting
    {
        public Win32DCOMApplicationSetting()
        {
        }

        public Win32DCOMApplicationSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AppID
        {
            get
            {
                System.String result;
                this.GetProperty("AppID", out result);
                return result;
            }
        }

        public System.UInt32? AuthenticationLevel
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AuthenticationLevel", out result);
                return result;
            }

            set
            {
                this.SetProperty("AuthenticationLevel", value);
            }
        }

        public System.String CustomSurrogate
        {
            get
            {
                System.String result;
                this.GetProperty("CustomSurrogate", out result);
                return result;
            }
        }

        public System.Boolean? EnableAtStorageActivation
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableAtStorageActivation", out result);
                return result;
            }
        }

        public System.String LocalService
        {
            get
            {
                System.String result;
                this.GetProperty("LocalService", out result);
                return result;
            }
        }

        public System.String RemoteServerName
        {
            get
            {
                System.String result;
                this.GetProperty("RemoteServerName", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteServerName", value);
            }
        }

        public System.String RunAsUser
        {
            get
            {
                System.String result;
                this.GetProperty("RunAsUser", out result);
                return result;
            }
        }

        public System.String ServiceParameters
        {
            get
            {
                System.String result;
                this.GetProperty("ServiceParameters", out result);
                return result;
            }
        }

        public System.Boolean? UseSurrogate
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("UseSurrogate", out result);
                return result;
            }

            set
            {
                this.SetProperty("UseSurrogate", value);
            }
        }

        public (System.UInt32 retval, Win32SecurityDescriptor outDescriptor) GetLaunchSecurityDescriptor()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetLaunchSecurityDescriptor", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (Win32SecurityDescriptor)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Descriptor"].Value));
        }

        public System.UInt32 SetLaunchSecurityDescriptor(Win32SecurityDescriptor inDescriptor)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Descriptor", inDescriptor.AsCimInstance(), CimType.Instance, inDescriptor == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetLaunchSecurityDescriptor", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, Win32SecurityDescriptor outDescriptor) GetAccessSecurityDescriptor()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetAccessSecurityDescriptor", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (Win32SecurityDescriptor)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Descriptor"].Value));
        }

        public System.UInt32 SetAccessSecurityDescriptor(Win32SecurityDescriptor inDescriptor)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Descriptor", inDescriptor.AsCimInstance(), CimType.Instance, inDescriptor == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetAccessSecurityDescriptor", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, Win32SecurityDescriptor outDescriptor) GetConfigurationSecurityDescriptor()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetConfigurationSecurityDescriptor", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (Win32SecurityDescriptor)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Descriptor"].Value));
        }

        public System.UInt32 SetConfigurationSecurityDescriptor(Win32SecurityDescriptor inDescriptor)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Descriptor", inDescriptor.AsCimInstance(), CimType.Instance, inDescriptor == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetConfigurationSecurityDescriptor", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public Win32DCOMApplication ResolveWin32COMApplicationSettingsElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_COMApplicationSettings", "Win32_DCOMApplication", "Setting", "Element");
            return instances.Select(i => (Win32DCOMApplication)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}