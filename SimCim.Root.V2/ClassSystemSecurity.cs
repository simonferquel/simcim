using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class SystemSecurity : GenericInfrastructureObject
    {
        public SystemSecurity()
        {
        }

        public SystemSecurity(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, System.Byte[] outSD) GetSD()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetSD", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Byte[])result.OutParameters["SD"].Value);
        }

        public (System.UInt32 retval, SecurityDescriptor outDescriptor) GetSecurityDescriptor()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetSecurityDescriptor", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (SecurityDescriptor)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Descriptor"].Value));
        }

        public (System.UInt32 retval, IEnumerable<CimInstance> outul) Get9XUserList()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Get9XUserList", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<CimInstance>)result.OutParameters["ul"].Value);
        }

        public System.UInt32 SetSD(System.Byte[] inSD)
        {
            var parameters = new CimMethodParametersCollection();
            if (inSD != null)
                parameters.Add(CimMethodParameter.Create("SD", inSD, CimType.UInt8Array, inSD == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetSD", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetSecurityDescriptor(SecurityDescriptor inDescriptor)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDescriptor != null)
                parameters.Add(CimMethodParameter.Create("Descriptor", inDescriptor.AsCimInstance(), CimType.Instance, inDescriptor == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetSecurityDescriptor", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Set9XUserList(IEnumerable<CimInstance> inul)
        {
            var parameters = new CimMethodParametersCollection();
            if (inul != null)
                parameters.Add(CimMethodParameter.Create("ul", inul, CimType.InstanceArray, inul == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Set9XUserList", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, System.Int32? outrights) GetCallerAccessRights()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetCallerAccessRights", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Int32? )result.OutParameters["rights"].Value);
        }
    }
}