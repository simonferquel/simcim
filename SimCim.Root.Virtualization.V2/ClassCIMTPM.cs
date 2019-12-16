using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMTPM : CIMLogicalDevice
    {
        protected CIMTPM()
        {
        }

        protected CIMTPM(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] AvailableRequestedTPMStates
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("AvailableRequestedTPMStates", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvailableRequestedTPMStates", value);
            }
        }

        public System.UInt32? TPMManafucturerMajorRevision
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TPMManafucturerMajorRevision", out result);
                return result;
            }

            set
            {
                this.SetProperty("TPMManafucturerMajorRevision", value);
            }
        }

        public System.UInt32? TPMManufacturerId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TPMManufacturerId", out result);
                return result;
            }

            set
            {
                this.SetProperty("TPMManufacturerId", value);
            }
        }

        public System.String TPMManufacturerInfo
        {
            get
            {
                System.String result;
                this.GetProperty("TPMManufacturerInfo", out result);
                return result;
            }

            set
            {
                this.SetProperty("TPMManufacturerInfo", value);
            }
        }

        public System.UInt32? TPMManufacturerMinorRevision
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TPMManufacturerMinorRevision", out result);
                return result;
            }

            set
            {
                this.SetProperty("TPMManufacturerMinorRevision", value);
            }
        }

        public System.UInt32? TPMSpecMajorVersion
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TPMSpecMajorVersion", out result);
                return result;
            }

            set
            {
                this.SetProperty("TPMSpecMajorVersion", value);
            }
        }

        public System.UInt32? TPMSpecMinorVersion
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TPMSpecMinorVersion", out result);
                return result;
            }

            set
            {
                this.SetProperty("TPMSpecMinorVersion", value);
            }
        }

        public System.UInt16? TPMState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TPMState", out result);
                return result;
            }

            set
            {
                this.SetProperty("TPMState", value);
            }
        }

        public System.UInt16? TransitioningToTPMState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TransitioningToTPMState", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransitioningToTPMState", value);
            }
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RequestTPMStateChange(System.String inAuthorizationToken, System.UInt16? inRequestedTPMState, System.DateTime? inTimeoutPeriod)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAuthorizationToken != null)
                parameters.Add(CimMethodParameter.Create("AuthorizationToken", inAuthorizationToken, CimType.String, inAuthorizationToken == null ? CimFlags.NullValue : CimFlags.None));
            if (inRequestedTPMState.HasValue)
                parameters.Add(CimMethodParameter.Create("RequestedTPMState", inRequestedTPMState.Value, CimFlags.None));
            if (inTimeoutPeriod.HasValue)
                parameters.Add(CimMethodParameter.Create("TimeoutPeriod", inTimeoutPeriod.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RequestTPMStateChange", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }

        public System.UInt32 ChangeOwnerAuth(System.String inNewOwnerAuth, System.String inOldOwnerAuth)
        {
            var parameters = new CimMethodParametersCollection();
            if (inNewOwnerAuth != null)
                parameters.Add(CimMethodParameter.Create("NewOwnerAuth", inNewOwnerAuth, CimType.String, inNewOwnerAuth == null ? CimFlags.NullValue : CimFlags.None));
            if (inOldOwnerAuth != null)
                parameters.Add(CimMethodParameter.Create("OldOwnerAuth", inOldOwnerAuth, CimType.String, inOldOwnerAuth == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ChangeOwnerAuth", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}