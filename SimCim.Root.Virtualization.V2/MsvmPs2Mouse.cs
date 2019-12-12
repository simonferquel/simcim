using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmPs2Mouse : CIMPointingDevice
    {
        public MsvmPs2Mouse()
        {
        }

        public MsvmPs2Mouse(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AbsoluteCoordinates
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AbsoluteCoordinates", out result);
                return result;
            }
        }

        public (System.UInt32 retval, System.Boolean? outButtonState) GetButtonState(System.UInt32? inButtonIndex)
        {
            var parameters = new CimMethodParametersCollection();
            if (inButtonIndex.HasValue)
                parameters.Add(CimMethodParameter.Create("ButtonIndex", inButtonIndex.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ButtonIndex", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetButtonState", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Boolean? )result.OutParameters["ButtonState"].Value);
        }

        public System.UInt32 SetButtonState(System.UInt32? inButtonIndex, System.Boolean? inButtonState)
        {
            var parameters = new CimMethodParametersCollection();
            if (inButtonIndex.HasValue)
                parameters.Add(CimMethodParameter.Create("ButtonIndex", inButtonIndex.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ButtonIndex", null, CimFlags.NullValue));
            if (inButtonState.HasValue)
                parameters.Add(CimMethodParameter.Create("ButtonState", inButtonState.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ButtonState", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetButtonState", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ClickButton(System.UInt32? inButtonIndex)
        {
            var parameters = new CimMethodParametersCollection();
            if (inButtonIndex.HasValue)
                parameters.Add(CimMethodParameter.Create("ButtonIndex", inButtonIndex.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ButtonIndex", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ClickButton", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetRelativePosition(System.SByte? inHorizontalDelta, System.SByte? inVerticalDelta)
        {
            var parameters = new CimMethodParametersCollection();
            if (inHorizontalDelta.HasValue)
                parameters.Add(CimMethodParameter.Create("HorizontalDelta", inHorizontalDelta.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("HorizontalDelta", null, CimFlags.NullValue));
            if (inVerticalDelta.HasValue)
                parameters.Add(CimMethodParameter.Create("VerticalDelta", inVerticalDelta.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("VerticalDelta", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetRelativePosition", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetScrollPosition(System.SByte? inScrollPositionDelta)
        {
            var parameters = new CimMethodParametersCollection();
            if (inScrollPositionDelta.HasValue)
                parameters.Add(CimMethodParameter.Create("ScrollPositionDelta", inScrollPositionDelta.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ScrollPositionDelta", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetScrollPosition", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}