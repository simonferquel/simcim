using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class StdRegProv : GenericInfrastructureObject
    {
        public StdRegProv()
        {
        }

        public StdRegProv(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32 CreateKey(System.UInt32? inhDefKey, System.String insSubKeyName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CreateKey", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 DeleteKey(System.UInt32? inhDefKey, System.String insSubKeyName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DeleteKey", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, System.String[] outsNames) EnumKey(System.UInt32? inhDefKey, System.String insSubKeyName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "EnumKey", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String[])result.OutParameters["sNames"].Value);
        }

        public (System.UInt32 retval, System.String[] outsNames, System.Int32[] outTypes) EnumValues(System.UInt32? inhDefKey, System.String insSubKeyName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "EnumValues", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String[])result.OutParameters["sNames"].Value, (System.Int32[])result.OutParameters["Types"].Value);
        }

        public System.UInt32 DeleteValue(System.UInt32? inhDefKey, System.String insSubKeyName, System.String insValueName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            if (insValueName != null)
                parameters.Add(CimMethodParameter.Create("sValueName", insValueName, CimType.String, insValueName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DeleteValue", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetDWORDValue(System.UInt32? inhDefKey, System.String insSubKeyName, System.String insValueName, System.UInt32? inuValue)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            if (insValueName != null)
                parameters.Add(CimMethodParameter.Create("sValueName", insValueName, CimType.String, insValueName == null ? CimFlags.NullValue : CimFlags.None));
            if (inuValue.HasValue)
                parameters.Add(CimMethodParameter.Create("uValue", inuValue.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetDWORDValue", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetQWORDValue(System.UInt32? inhDefKey, System.String insSubKeyName, System.String insValueName, System.UInt64? inuValue)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            if (insValueName != null)
                parameters.Add(CimMethodParameter.Create("sValueName", insValueName, CimType.String, insValueName == null ? CimFlags.NullValue : CimFlags.None));
            if (inuValue.HasValue)
                parameters.Add(CimMethodParameter.Create("uValue", inuValue.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetQWORDValue", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, System.UInt32? outuValue) GetDWORDValue(System.UInt32? inhDefKey, System.String insSubKeyName, System.String insValueName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            if (insValueName != null)
                parameters.Add(CimMethodParameter.Create("sValueName", insValueName, CimType.String, insValueName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetDWORDValue", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.UInt32? )result.OutParameters["uValue"].Value);
        }

        public (System.UInt32 retval, System.UInt64? outuValue) GetQWORDValue(System.UInt32? inhDefKey, System.String insSubKeyName, System.String insValueName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            if (insValueName != null)
                parameters.Add(CimMethodParameter.Create("sValueName", insValueName, CimType.String, insValueName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetQWORDValue", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.UInt64? )result.OutParameters["uValue"].Value);
        }

        public System.UInt32 SetStringValue(System.UInt32? inhDefKey, System.String insSubKeyName, System.String insValue, System.String insValueName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            if (insValue != null)
                parameters.Add(CimMethodParameter.Create("sValue", insValue, CimType.String, insValue == null ? CimFlags.NullValue : CimFlags.None));
            if (insValueName != null)
                parameters.Add(CimMethodParameter.Create("sValueName", insValueName, CimType.String, insValueName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetStringValue", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, System.String outsValue) GetStringValue(System.UInt32? inhDefKey, System.String insSubKeyName, System.String insValueName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            if (insValueName != null)
                parameters.Add(CimMethodParameter.Create("sValueName", insValueName, CimType.String, insValueName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetStringValue", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["sValue"].Value);
        }

        public System.UInt32 SetMultiStringValue(System.UInt32? inhDefKey, System.String insSubKeyName, System.String[] insValue, System.String insValueName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            if (insValue != null)
                parameters.Add(CimMethodParameter.Create("sValue", insValue, CimType.StringArray, insValue == null ? CimFlags.NullValue : CimFlags.None));
            if (insValueName != null)
                parameters.Add(CimMethodParameter.Create("sValueName", insValueName, CimType.String, insValueName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetMultiStringValue", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, System.String[] outsValue) GetMultiStringValue(System.UInt32? inhDefKey, System.String insSubKeyName, System.String insValueName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            if (insValueName != null)
                parameters.Add(CimMethodParameter.Create("sValueName", insValueName, CimType.String, insValueName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetMultiStringValue", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String[])result.OutParameters["sValue"].Value);
        }

        public System.UInt32 SetExpandedStringValue(System.UInt32? inhDefKey, System.String insSubKeyName, System.String insValue, System.String insValueName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            if (insValue != null)
                parameters.Add(CimMethodParameter.Create("sValue", insValue, CimType.String, insValue == null ? CimFlags.NullValue : CimFlags.None));
            if (insValueName != null)
                parameters.Add(CimMethodParameter.Create("sValueName", insValueName, CimType.String, insValueName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetExpandedStringValue", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, System.String outsValue) GetExpandedStringValue(System.UInt32? inhDefKey, System.String insSubKeyName, System.String insValueName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            if (insValueName != null)
                parameters.Add(CimMethodParameter.Create("sValueName", insValueName, CimType.String, insValueName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetExpandedStringValue", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["sValue"].Value);
        }

        public System.UInt32 SetBinaryValue(System.UInt32? inhDefKey, System.String insSubKeyName, System.String insValueName, System.Byte[] inuValue)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            if (insValueName != null)
                parameters.Add(CimMethodParameter.Create("sValueName", insValueName, CimType.String, insValueName == null ? CimFlags.NullValue : CimFlags.None));
            if (inuValue != null)
                parameters.Add(CimMethodParameter.Create("uValue", inuValue, CimType.UInt8Array, inuValue == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetBinaryValue", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, System.Byte[] outuValue) GetBinaryValue(System.UInt32? inhDefKey, System.String insSubKeyName, System.String insValueName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            if (insValueName != null)
                parameters.Add(CimMethodParameter.Create("sValueName", insValueName, CimType.String, insValueName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetBinaryValue", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Byte[])result.OutParameters["uValue"].Value);
        }

        public (System.UInt32 retval, System.Boolean? outbGranted) CheckAccess(System.UInt32? inhDefKey, System.String insSubKeyName, System.UInt32? inuRequired)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            if (inuRequired.HasValue)
                parameters.Add(CimMethodParameter.Create("uRequired", inuRequired.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CheckAccess", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Boolean? )result.OutParameters["bGranted"].Value);
        }

        public System.UInt32 SetSecurityDescriptor(SecurityDescriptor inDescriptor, System.UInt32? inhDefKey, System.String insSubKeyName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDescriptor != null)
                parameters.Add(CimMethodParameter.Create("Descriptor", inDescriptor.AsCimInstance(), CimType.Instance, inDescriptor == null ? CimFlags.NullValue : CimFlags.None));
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetSecurityDescriptor", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, SecurityDescriptor outDescriptor) GetSecurityDescriptor(System.UInt32? inhDefKey, System.String insSubKeyName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inhDefKey.HasValue)
                parameters.Add(CimMethodParameter.Create("hDefKey", inhDefKey.Value, CimFlags.None));
            if (insSubKeyName != null)
                parameters.Add(CimMethodParameter.Create("sSubKeyName", insSubKeyName, CimType.String, insSubKeyName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetSecurityDescriptor", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (SecurityDescriptor)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Descriptor"].Value));
        }
    }
}