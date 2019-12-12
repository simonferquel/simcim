using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class SoftwareLicensingProduct : GenericInfrastructureObject
    {
        public SoftwareLicensingProduct()
        {
        }

        public SoftwareLicensingProduct(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ADActivationCsvlkPid
        {
            get
            {
                System.String result;
                this.GetProperty("ADActivationCsvlkPid", out result);
                return result;
            }
        }

        public System.String ADActivationCsvlkSkuId
        {
            get
            {
                System.String result;
                this.GetProperty("ADActivationCsvlkSkuId", out result);
                return result;
            }
        }

        public System.String ADActivationObjectDN
        {
            get
            {
                System.String result;
                this.GetProperty("ADActivationObjectDN", out result);
                return result;
            }
        }

        public System.String ADActivationObjectName
        {
            get
            {
                System.String result;
                this.GetProperty("ADActivationObjectName", out result);
                return result;
            }
        }

        public System.String ApplicationID
        {
            get
            {
                System.String result;
                this.GetProperty("ApplicationID", out result);
                return result;
            }
        }

        public System.String AutomaticVMActivationHostDigitalPid2
        {
            get
            {
                System.String result;
                this.GetProperty("AutomaticVMActivationHostDigitalPid2", out result);
                return result;
            }
        }

        public System.String AutomaticVMActivationHostMachineName
        {
            get
            {
                System.String result;
                this.GetProperty("AutomaticVMActivationHostMachineName", out result);
                return result;
            }
        }

        public System.DateTime? AutomaticVMActivationLastActivationTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("AutomaticVMActivationLastActivationTime", out result);
                return result;
            }
        }

        public System.String Description
        {
            get
            {
                System.String result;
                this.GetProperty("Description", out result);
                return result;
            }
        }

        public System.String DiscoveredKeyManagementServiceMachineIpAddress
        {
            get
            {
                System.String result;
                this.GetProperty("DiscoveredKeyManagementServiceMachineIpAddress", out result);
                return result;
            }
        }

        public System.String DiscoveredKeyManagementServiceMachineName
        {
            get
            {
                System.String result;
                this.GetProperty("DiscoveredKeyManagementServiceMachineName", out result);
                return result;
            }
        }

        public System.UInt32? DiscoveredKeyManagementServiceMachinePort
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DiscoveredKeyManagementServiceMachinePort", out result);
                return result;
            }
        }

        public System.DateTime? EvaluationEndDate
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("EvaluationEndDate", out result);
                return result;
            }
        }

        public System.UInt32? ExtendedGrace
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExtendedGrace", out result);
                return result;
            }
        }

        public System.UInt32? GenuineStatus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("GenuineStatus", out result);
                return result;
            }
        }

        public System.UInt32? GracePeriodRemaining
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("GracePeriodRemaining", out result);
                return result;
            }
        }

        public System.String IAID
        {
            get
            {
                System.String result;
                this.GetProperty("IAID", out result);
                return result;
            }
        }

        public System.String ID
        {
            get
            {
                System.String result;
                this.GetProperty("ID", out result);
                return result;
            }
        }

        public System.UInt32? IsKeyManagementServiceMachine
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IsKeyManagementServiceMachine", out result);
                return result;
            }
        }

        public System.UInt32? KeyManagementServiceCurrentCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KeyManagementServiceCurrentCount", out result);
                return result;
            }
        }

        public System.UInt32? KeyManagementServiceFailedRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KeyManagementServiceFailedRequests", out result);
                return result;
            }
        }

        public System.UInt32? KeyManagementServiceLicensedRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KeyManagementServiceLicensedRequests", out result);
                return result;
            }
        }

        public System.String KeyManagementServiceLookupDomain
        {
            get
            {
                System.String result;
                this.GetProperty("KeyManagementServiceLookupDomain", out result);
                return result;
            }
        }

        public System.String KeyManagementServiceMachine
        {
            get
            {
                System.String result;
                this.GetProperty("KeyManagementServiceMachine", out result);
                return result;
            }
        }

        public System.UInt32? KeyManagementServiceNonGenuineGraceRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KeyManagementServiceNonGenuineGraceRequests", out result);
                return result;
            }
        }

        public System.UInt32? KeyManagementServiceNotificationRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KeyManagementServiceNotificationRequests", out result);
                return result;
            }
        }

        public System.UInt32? KeyManagementServiceOOBGraceRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KeyManagementServiceOOBGraceRequests", out result);
                return result;
            }
        }

        public System.UInt32? KeyManagementServiceOOTGraceRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KeyManagementServiceOOTGraceRequests", out result);
                return result;
            }
        }

        public System.UInt32? KeyManagementServicePort
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KeyManagementServicePort", out result);
                return result;
            }
        }

        public System.String KeyManagementServiceProductKeyID
        {
            get
            {
                System.String result;
                this.GetProperty("KeyManagementServiceProductKeyID", out result);
                return result;
            }
        }

        public System.UInt32? KeyManagementServiceTotalRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KeyManagementServiceTotalRequests", out result);
                return result;
            }
        }

        public System.UInt32? KeyManagementServiceUnlicensedRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KeyManagementServiceUnlicensedRequests", out result);
                return result;
            }
        }

        public System.String LicenseDependsOn
        {
            get
            {
                System.String result;
                this.GetProperty("LicenseDependsOn", out result);
                return result;
            }
        }

        public System.String LicenseFamily
        {
            get
            {
                System.String result;
                this.GetProperty("LicenseFamily", out result);
                return result;
            }
        }

        public System.Boolean? LicenseIsAddon
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("LicenseIsAddon", out result);
                return result;
            }
        }

        public System.UInt32? LicenseStatus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LicenseStatus", out result);
                return result;
            }
        }

        public System.UInt32? LicenseStatusReason
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LicenseStatusReason", out result);
                return result;
            }
        }

        public System.String MachineURL
        {
            get
            {
                System.String result;
                this.GetProperty("MachineURL", out result);
                return result;
            }
        }

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
                return result;
            }
        }

        public System.String OfflineInstallationId
        {
            get
            {
                System.String result;
                this.GetProperty("OfflineInstallationId", out result);
                return result;
            }
        }

        public System.String PartialProductKey
        {
            get
            {
                System.String result;
                this.GetProperty("PartialProductKey", out result);
                return result;
            }
        }

        public System.String ProcessorURL
        {
            get
            {
                System.String result;
                this.GetProperty("ProcessorURL", out result);
                return result;
            }
        }

        public System.String ProductKeyChannel
        {
            get
            {
                System.String result;
                this.GetProperty("ProductKeyChannel", out result);
                return result;
            }
        }

        public System.String ProductKeyID
        {
            get
            {
                System.String result;
                this.GetProperty("ProductKeyID", out result);
                return result;
            }
        }

        public System.String ProductKeyID2
        {
            get
            {
                System.String result;
                this.GetProperty("ProductKeyID2", out result);
                return result;
            }
        }

        public System.String ProductKeyURL
        {
            get
            {
                System.String result;
                this.GetProperty("ProductKeyURL", out result);
                return result;
            }
        }

        public System.UInt32? RemainingAppReArmCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RemainingAppReArmCount", out result);
                return result;
            }
        }

        public System.UInt32? RemainingSkuReArmCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RemainingSkuReArmCount", out result);
                return result;
            }
        }

        public System.UInt32? RequiredClientCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequiredClientCount", out result);
                return result;
            }
        }

        public System.String TokenActivationAdditionalInfo
        {
            get
            {
                System.String result;
                this.GetProperty("TokenActivationAdditionalInfo", out result);
                return result;
            }
        }

        public System.String TokenActivationCertificateThumbprint
        {
            get
            {
                System.String result;
                this.GetProperty("TokenActivationCertificateThumbprint", out result);
                return result;
            }
        }

        public System.UInt32? TokenActivationGrantNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TokenActivationGrantNumber", out result);
                return result;
            }
        }

        public System.String TokenActivationILID
        {
            get
            {
                System.String result;
                this.GetProperty("TokenActivationILID", out result);
                return result;
            }
        }

        public System.UInt32? TokenActivationILVID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TokenActivationILVID", out result);
                return result;
            }
        }

        public System.DateTime? TrustedTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TrustedTime", out result);
                return result;
            }
        }

        public System.String UseLicenseURL
        {
            get
            {
                System.String result;
                this.GetProperty("UseLicenseURL", out result);
                return result;
            }
        }

        public System.String ValidationURL
        {
            get
            {
                System.String result;
                this.GetProperty("ValidationURL", out result);
                return result;
            }
        }

        public System.UInt32? VLActivationInterval
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VLActivationInterval", out result);
                return result;
            }
        }

        public System.UInt32? VLActivationType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VLActivationType", out result);
                return result;
            }
        }

        public System.UInt32? VLActivationTypeEnabled
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VLActivationTypeEnabled", out result);
                return result;
            }
        }

        public System.UInt32? VLRenewalInterval
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VLRenewalInterval", out result);
                return result;
            }
        }

        public System.UInt32 UninstallProductKey()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "UninstallProductKey", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Activate()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Activate", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 DepositOfflineConfirmationId(System.String inConfirmationId, System.String inInstallationId)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ConfirmationId", inConfirmationId, inConfirmationId == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("InstallationId", inInstallationId, inInstallationId == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DepositOfflineConfirmationId", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, System.UInt32? outPolicyValue) GetPolicyInformationDWord(System.String inPolicyName)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("PolicyName", inPolicyName, inPolicyName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetPolicyInformationDWord", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.UInt32? )result.OutParameters["PolicyValue"].Value);
        }

        public (System.UInt32 retval, System.String outPolicyValue) GetPolicyInformationString(System.String inPolicyName)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("PolicyName", inPolicyName, inPolicyName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetPolicyInformationString", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["PolicyValue"].Value);
        }

        public System.UInt32 SetKeyManagementServiceMachine(System.String inMachineName)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("MachineName", inMachineName, inMachineName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetKeyManagementServiceMachine", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ClearKeyManagementServiceMachine()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ClearKeyManagementServiceMachine", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetKeyManagementServicePort(System.UInt32? inPortNumber)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPortNumber.HasValue)
                parameters.Add(CimMethodParameter.Create("PortNumber", inPortNumber.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("PortNumber", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetKeyManagementServicePort", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ClearKeyManagementServicePort()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ClearKeyManagementServicePort", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetKeyManagementServiceLookupDomain(System.String inLookupDomain)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("LookupDomain", inLookupDomain, inLookupDomain == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetKeyManagementServiceLookupDomain", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ClearKeyManagementServiceLookupDomain()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ClearKeyManagementServiceLookupDomain", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, System.String[] outGrants) GetTokenActivationGrants()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetTokenActivationGrants", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String[])result.OutParameters["Grants"].Value);
        }

        public (System.UInt32 retval, System.String outChallenge) GenerateTokenActivationChallenge()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GenerateTokenActivationChallenge", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["Challenge"].Value);
        }

        public System.UInt32 DepositTokenActivationResponse(System.String inCertChain, System.String inChallenge, System.String inResponse)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("CertChain", inCertChain, inCertChain == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("Challenge", inChallenge, inChallenge == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("Response", inResponse, inResponse == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DepositTokenActivationResponse", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetVLActivationTypeEnabled(System.UInt32? inActivationType)
        {
            var parameters = new CimMethodParametersCollection();
            if (inActivationType.HasValue)
                parameters.Add(CimMethodParameter.Create("ActivationType", inActivationType.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ActivationType", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetVLActivationTypeEnabled", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ClearVLActivationTypeEnabled()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ClearVLActivationTypeEnabled", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ReArmSku()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ReArmSku", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}