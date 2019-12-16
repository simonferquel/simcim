using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmKeyboard : CIMUserDevice
    {
        public MsvmKeyboard()
        {
        }

        public MsvmKeyboard(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Layout
        {
            get
            {
                System.String result;
                this.GetProperty("Layout", out result);
                return result;
            }
        }

        public System.UInt16? NumberOfFunctionKeys
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NumberOfFunctionKeys", out result);
                return result;
            }
        }

        public System.UInt16? Password
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Password", out result);
                return result;
            }
        }

        public System.Boolean? UnicodeSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("UnicodeSupported", out result);
                return result;
            }
        }

        public System.UInt32 PressKey(System.UInt32? inKeyCode)
        {
            var parameters = new CimMethodParametersCollection();
            if (inKeyCode.HasValue)
                parameters.Add(CimMethodParameter.Create("KeyCode", inKeyCode.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("KeyCode", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "PressKey", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ReleaseKey(System.UInt32? inKeyCode)
        {
            var parameters = new CimMethodParametersCollection();
            if (inKeyCode.HasValue)
                parameters.Add(CimMethodParameter.Create("KeyCode", inKeyCode.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("KeyCode", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ReleaseKey", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 TypeKey(System.UInt32? inKeyCode)
        {
            var parameters = new CimMethodParametersCollection();
            if (inKeyCode.HasValue)
                parameters.Add(CimMethodParameter.Create("KeyCode", inKeyCode.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("KeyCode", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "TypeKey", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, System.Boolean? outKeyState) IsKeyPressed(System.UInt32? inKeyCode)
        {
            var parameters = new CimMethodParametersCollection();
            if (inKeyCode.HasValue)
                parameters.Add(CimMethodParameter.Create("KeyCode", inKeyCode.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("KeyCode", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "IsKeyPressed", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Boolean? )result.OutParameters["KeyState"].Value);
        }

        public System.UInt32 TypeText(System.String inAsciiText)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAsciiText != null)
                parameters.Add(CimMethodParameter.Create("AsciiText", inAsciiText, CimType.String, inAsciiText == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "TypeText", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 TypeCtrlAltDel()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "TypeCtrlAltDel", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 TypeScancodes(System.Byte[] inScancodes)
        {
            var parameters = new CimMethodParametersCollection();
            if (inScancodes != null)
                parameters.Add(CimMethodParameter.Create("Scancodes", inScancodes, CimType.UInt8Array, inScancodes == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "TypeScancodes", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}