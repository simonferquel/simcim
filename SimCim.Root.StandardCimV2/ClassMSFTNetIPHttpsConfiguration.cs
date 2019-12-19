using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetIPHttpsConfiguration : MSFTNetSettingData
    {
        public MSFTNetIPHttpsConfiguration()
        {
        }

        public MSFTNetIPHttpsConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AuthMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AuthMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("AuthMode", value);
            }
        }

        public System.UInt32? ConfigurationType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConfigurationType", out result);
                return result;
            }
        }

        public System.String PolicyStore
        {
            get
            {
                System.String result;
                this.GetProperty("PolicyStore", out result);
                return result;
            }
        }

        public System.String Profile
        {
            get
            {
                System.String result;
                this.GetProperty("Profile", out result);
                return result;
            }

            set
            {
                this.SetProperty("Profile", value);
            }
        }

        public System.Boolean? ProfileActivated
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ProfileActivated", out result);
                return result;
            }
        }

        public System.String ServerURL
        {
            get
            {
                System.String result;
                this.GetProperty("ServerURL", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServerURL", value);
            }
        }

        public System.UInt32? State
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("State", out result);
                return result;
            }

            set
            {
                this.SetProperty("State", value);
            }
        }

        public System.Boolean? StrongCRLRequired
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("StrongCRLRequired", out result);
                return result;
            }

            set
            {
                this.SetProperty("StrongCRLRequired", value);
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

            set
            {
                this.SetProperty("Type", value);
            }
        }

        public System.UInt32 EnableProfile(System.String inProfile)
        {
            var parameters = new CimMethodParametersCollection();
            if (inProfile != null)
                parameters.Add(CimMethodParameter.Create("Profile", inProfile, CimType.String, inProfile == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "EnableProfile", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 DisableProfile()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DisableProfile", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 AddCertBinding(System.String inApplicationId, System.String inCertificateHash, System.String inCertificateStoreName, System.String inIpPort, System.Boolean? inNullEncryption)
        {
            var parameters = new CimMethodParametersCollection();
            if (inApplicationId != null)
                parameters.Add(CimMethodParameter.Create("ApplicationId", inApplicationId, CimType.String, inApplicationId == null ? CimFlags.NullValue : CimFlags.None));
            if (inCertificateHash != null)
                parameters.Add(CimMethodParameter.Create("CertificateHash", inCertificateHash, CimType.String, inCertificateHash == null ? CimFlags.NullValue : CimFlags.None));
            if (inCertificateStoreName != null)
                parameters.Add(CimMethodParameter.Create("CertificateStoreName", inCertificateStoreName, CimType.String, inCertificateStoreName == null ? CimFlags.NullValue : CimFlags.None));
            if (inIpPort != null)
                parameters.Add(CimMethodParameter.Create("IpPort", inIpPort, CimType.String, inIpPort == null ? CimFlags.NullValue : CimFlags.None));
            if (inNullEncryption.HasValue)
                parameters.Add(CimMethodParameter.Create("NullEncryption", inNullEncryption.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddCertBinding", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 RemoveCertBinding()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveCertBinding", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, MSFTNetIPHttpsConfiguration outOutputObject) Rename(System.String inNewName, System.Boolean? inPassThru)
        {
            var parameters = new CimMethodParametersCollection();
            if (inNewName != null)
                parameters.Add(CimMethodParameter.Create("NewName", inNewName, CimType.String, inNewName == null ? CimFlags.NullValue : CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Rename", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetIPHttpsConfiguration)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["OutputObject"].Value));
        }

        public (System.UInt32 retval, MSFTNetIPHttpsConfiguration outOutputObject) Reset(System.Boolean? inAuthMode, System.Boolean? inPassThru, System.Boolean? inState, System.Boolean? inStrongCRLRequired)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAuthMode.HasValue)
                parameters.Add(CimMethodParameter.Create("AuthMode", inAuthMode.Value, CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            if (inState.HasValue)
                parameters.Add(CimMethodParameter.Create("State", inState.Value, CimFlags.None));
            if (inStrongCRLRequired.HasValue)
                parameters.Add(CimMethodParameter.Create("StrongCRLRequired", inStrongCRLRequired.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Reset", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetIPHttpsConfiguration)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["OutputObject"].Value));
        }
    }
}