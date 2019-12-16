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
            return ((System.UInt32)result.ReturnValue.Value, (Win32SecurityDescriptor)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Descriptor"].Value));
        }

        public System.UInt32 SetSecurityDescriptor(Win32SecurityDescriptor inDescriptor)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDescriptor != null)
                parameters.Add(CimMethodParameter.Create("Descriptor", inDescriptor.AsCimInstance(), CimType.Instance, inDescriptor == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetSecurityDescriptor", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}