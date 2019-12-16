using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Share : CIMLogicalElement
    {
        public Win32Share()
        {
        }

        public Win32Share(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AccessMask
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AccessMask", out result);
                return result;
            }
        }

        public System.Boolean? AllowMaximum
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AllowMaximum", out result);
                return result;
            }
        }

        public System.UInt32? MaximumAllowed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumAllowed", out result);
                return result;
            }
        }

        public System.String Path
        {
            get
            {
                System.String result;
                this.GetProperty("Path", out result);
                return result;
            }
        }

        public System.UInt32? Type
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Type", out result);
                return result;
            }
        }

        public System.UInt32 Create(Win32SecurityDescriptor inAccess, System.String inDescription, System.UInt32? inMaximumAllowed, System.String inName, System.String inPassword, System.String inPath, System.UInt32? inType)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAccess != null)
                parameters.Add(CimMethodParameter.Create("Access", inAccess.AsCimInstance(), CimType.Instance, inAccess == null ? CimFlags.NullValue : CimFlags.None));
            if (inDescription != null)
                parameters.Add(CimMethodParameter.Create("Description", inDescription, CimType.String, inDescription == null ? CimFlags.NullValue : CimFlags.None));
            if (inMaximumAllowed.HasValue)
                parameters.Add(CimMethodParameter.Create("MaximumAllowed", inMaximumAllowed.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("MaximumAllowed", null, CimFlags.NullValue));
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            if (inPassword != null)
                parameters.Add(CimMethodParameter.Create("Password", inPassword, CimType.String, inPassword == null ? CimFlags.NullValue : CimFlags.None));
            if (inPath != null)
                parameters.Add(CimMethodParameter.Create("Path", inPath, CimType.String, inPath == null ? CimFlags.NullValue : CimFlags.None));
            if (inType.HasValue)
                parameters.Add(CimMethodParameter.Create("Type", inType.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Type", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Create", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetShareInfo(Win32SecurityDescriptor inAccess, System.String inDescription, System.UInt32? inMaximumAllowed)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAccess != null)
                parameters.Add(CimMethodParameter.Create("Access", inAccess.AsCimInstance(), CimType.Instance, inAccess == null ? CimFlags.NullValue : CimFlags.None));
            if (inDescription != null)
                parameters.Add(CimMethodParameter.Create("Description", inDescription, CimType.String, inDescription == null ? CimFlags.NullValue : CimFlags.None));
            if (inMaximumAllowed.HasValue)
                parameters.Add(CimMethodParameter.Create("MaximumAllowed", inMaximumAllowed.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("MaximumAllowed", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetShareInfo", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 GetAccessMask()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetAccessMask", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Delete()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Delete", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public Win32Printer ResolveWin32PrinterShareAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_PrinterShare", "Win32_Printer", "Dependent", "Antecedent");
            return instances.Select(i => (Win32Printer)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32ServerConnection ResolveWin32ConnectionShareDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ConnectionShare", "Win32_ServerConnection", "Antecedent", "Dependent");
            return instances.Select(i => (Win32ServerConnection)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32LogicalShareSecuritySetting ResolveWin32SecuritySettingOfLogicalShareSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SecuritySettingOfLogicalShare", "Win32_LogicalShareSecuritySetting", "Element", "Setting");
            return instances.Select(i => (Win32LogicalShareSecuritySetting)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMDirectory ResolveWin32ShareToDirectorySharedElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ShareToDirectory", "CIM_Directory", "Share", "SharedElement");
            return instances.Select(i => (CIMDirectory)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}