using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMEnabledLogicalElement : CIMLogicalElement
    {
        protected CIMEnabledLogicalElement()
        {
        }

        protected CIMEnabledLogicalElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] AvailableRequestedStates
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("AvailableRequestedStates", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvailableRequestedStates", value);
            }
        }

        public System.UInt16? EnabledDefault
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EnabledDefault", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnabledDefault", value);
            }
        }

        public System.UInt16? EnabledState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EnabledState", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnabledState", value);
            }
        }

        public System.String OtherEnabledState
        {
            get
            {
                System.String result;
                this.GetProperty("OtherEnabledState", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherEnabledState", value);
            }
        }

        public System.UInt16? RequestedState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("RequestedState", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestedState", value);
            }
        }

        public System.DateTime? TimeOfLastStateChange
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeOfLastStateChange", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimeOfLastStateChange", value);
            }
        }

        public System.UInt16? TransitioningToState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TransitioningToState", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransitioningToState", value);
            }
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RequestStateChange(System.UInt16? inRequestedState, System.DateTime? inTimeoutPeriod)
        {
            var parameters = new CimMethodParametersCollection();
            if (inRequestedState.HasValue)
                parameters.Add(CimMethodParameter.Create("RequestedState", inRequestedState.Value, CimFlags.None));
            if (inTimeoutPeriod.HasValue)
                parameters.Add(CimMethodParameter.Create("TimeoutPeriod", inTimeoutPeriod.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RequestStateChange", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }
    }
}