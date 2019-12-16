using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SecurityDescriptorHelper : GenericInfrastructureObject
    {
        public Win32SecurityDescriptorHelper()
        {
        }

        public Win32SecurityDescriptorHelper(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, System.String outSDDL) Win32SDToSDDL(SecurityDescriptor inDescriptor)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDescriptor != null)
                parameters.Add(CimMethodParameter.Create("Descriptor", inDescriptor.AsCimInstance(), CimType.Instance, inDescriptor == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Win32SDToSDDL", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["SDDL"].Value);
        }

        public (System.UInt32 retval, System.Byte[] outBinarySD) Win32SDToBinarySD(SecurityDescriptor inDescriptor)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDescriptor != null)
                parameters.Add(CimMethodParameter.Create("Descriptor", inDescriptor.AsCimInstance(), CimType.Instance, inDescriptor == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Win32SDToBinarySD", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Byte[])result.OutParameters["BinarySD"].Value);
        }

        public (System.UInt32 retval, SecurityDescriptor outDescriptor) SDDLToWin32SD(System.String inSDDL)
        {
            var parameters = new CimMethodParametersCollection();
            if (inSDDL != null)
                parameters.Add(CimMethodParameter.Create("SDDL", inSDDL, CimType.String, inSDDL == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SDDLToWin32SD", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (SecurityDescriptor)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Descriptor"].Value));
        }

        public (System.UInt32 retval, System.Byte[] outBinarySD) SDDLToBinarySD(System.String inSDDL)
        {
            var parameters = new CimMethodParametersCollection();
            if (inSDDL != null)
                parameters.Add(CimMethodParameter.Create("SDDL", inSDDL, CimType.String, inSDDL == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SDDLToBinarySD", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Byte[])result.OutParameters["BinarySD"].Value);
        }

        public (System.UInt32 retval, SecurityDescriptor outDescriptor) BinarySDToWin32SD(System.Byte[] inBinarySD)
        {
            var parameters = new CimMethodParametersCollection();
            if (inBinarySD != null)
                parameters.Add(CimMethodParameter.Create("BinarySD", inBinarySD, CimType.UInt8Array, inBinarySD == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "BinarySDToWin32SD", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (SecurityDescriptor)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Descriptor"].Value));
        }

        public (System.UInt32 retval, System.String outSDDL) BinarySDToSDDL(System.Byte[] inBinarySD)
        {
            var parameters = new CimMethodParametersCollection();
            if (inBinarySD != null)
                parameters.Add(CimMethodParameter.Create("BinarySD", inBinarySD, CimType.UInt8Array, inBinarySD == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "BinarySDToSDDL", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["SDDL"].Value);
        }
    }
}