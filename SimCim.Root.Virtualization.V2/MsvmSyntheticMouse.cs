using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSyntheticMouse : CIMPointingDevice
    {
        public MsvmSyntheticMouse()
        {
        }

        public MsvmSyntheticMouse(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.Int32? HorizontalPosition
        {
            get
            {
                System.Int32? result;
                this.GetProperty("HorizontalPosition", out result);
                return result;
            }
        }

        public System.Int32? ScrollPosition
        {
            get
            {
                System.Int32? result;
                this.GetProperty("ScrollPosition", out result);
                return result;
            }
        }

        public System.Int32? VerticalPosition
        {
            get
            {
                System.Int32? result;
                this.GetProperty("VerticalPosition", out result);
                return result;
            }
        }

        public (System.UInt32 retval, System.Boolean? outIsDown) GetButtonState(System.UInt32? inButtonIndex)
        {
            var parameters = new CimMethodParametersCollection();
            if (inButtonIndex.HasValue)
                parameters.Add(CimMethodParameter.Create("ButtonIndex", inButtonIndex.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ButtonIndex", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetButtonState", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Boolean? )result.OutParameters["IsDown"].Value);
        }

        public System.UInt32 SetButtonState(System.UInt32? inButtonIndex, System.Boolean? inIsDown)
        {
            var parameters = new CimMethodParametersCollection();
            if (inButtonIndex.HasValue)
                parameters.Add(CimMethodParameter.Create("ButtonIndex", inButtonIndex.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ButtonIndex", null, CimFlags.NullValue));
            if (inIsDown.HasValue)
                parameters.Add(CimMethodParameter.Create("IsDown", inIsDown.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("IsDown", null, CimFlags.NullValue));
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

        public System.UInt32 SetAbsolutePosition(System.Int32? inHorizontalPosition, System.Int32? inVerticalPosition)
        {
            var parameters = new CimMethodParametersCollection();
            if (inHorizontalPosition.HasValue)
                parameters.Add(CimMethodParameter.Create("HorizontalPosition", inHorizontalPosition.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("HorizontalPosition", null, CimFlags.NullValue));
            if (inVerticalPosition.HasValue)
                parameters.Add(CimMethodParameter.Create("VerticalPosition", inVerticalPosition.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("VerticalPosition", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetAbsolutePosition", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetScrollPosition(System.Int32? inScrollPositionDelta)
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