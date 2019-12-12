using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class SoftwareLicensingService : GenericInfrastructureObject
    {
        public SoftwareLicensingService()
        {
        }

        public SoftwareLicensingService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ClientMachineID
        {
            get
            {
                System.String result;
                this.GetProperty("ClientMachineID", out result);
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

        public System.Boolean? KeyManagementServiceDnsPublishing
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("KeyManagementServiceDnsPublishing", out result);
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

        public System.Boolean? KeyManagementServiceHostCaching
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("KeyManagementServiceHostCaching", out result);
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

        public System.UInt32? KeyManagementServiceListeningPort
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KeyManagementServiceListeningPort", out result);
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

        public System.Boolean? KeyManagementServiceLowPriority
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("KeyManagementServiceLowPriority", out result);
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

        public System.UInt32? OA2xBiosMarkerMinorVersion
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OA2xBiosMarkerMinorVersion", out result);
                return result;
            }
        }

        public System.UInt32? OA2xBiosMarkerStatus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OA2xBiosMarkerStatus", out result);
                return result;
            }
        }

        public System.String OA3xOriginalProductKey
        {
            get
            {
                System.String result;
                this.GetProperty("OA3xOriginalProductKey", out result);
                return result;
            }
        }

        public System.String OA3xOriginalProductKeyDescription
        {
            get
            {
                System.String result;
                this.GetProperty("OA3xOriginalProductKeyDescription", out result);
                return result;
            }
        }

        public System.String OA3xOriginalProductKeyPkPn
        {
            get
            {
                System.String result;
                this.GetProperty("OA3xOriginalProductKeyPkPn", out result);
                return result;
            }
        }

        public System.UInt32? PolicyCacheRefreshRequired
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PolicyCacheRefreshRequired", out result);
                return result;
            }
        }

        public System.UInt32? RemainingWindowsReArmCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RemainingWindowsReArmCount", out result);
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

        public System.String Version
        {
            get
            {
                System.String result;
                this.GetProperty("Version", out result);
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

        public System.UInt32? VLRenewalInterval
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VLRenewalInterval", out result);
                return result;
            }
        }

        public System.UInt32 InstallProductKey(System.String inProductKey)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ProductKey", inProductKey, inProductKey == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "InstallProductKey", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 InstallLicense(System.String inLicense)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("License", inLicense, inLicense == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "InstallLicense", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 InstallLicensePackage(System.String inLicensePackage)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("LicensePackage", inLicensePackage, inLicensePackage == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "InstallLicensePackage", parameters);
            return (System.UInt32)result.ReturnValue.Value;
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

        public System.UInt32 SetVLActivationInterval(System.UInt32? inActivationInterval)
        {
            var parameters = new CimMethodParametersCollection();
            if (inActivationInterval.HasValue)
                parameters.Add(CimMethodParameter.Create("ActivationInterval", inActivationInterval.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ActivationInterval", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetVLActivationInterval", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetVLRenewalInterval(System.UInt32? inRenewalInterval)
        {
            var parameters = new CimMethodParametersCollection();
            if (inRenewalInterval.HasValue)
                parameters.Add(CimMethodParameter.Create("RenewalInterval", inRenewalInterval.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("RenewalInterval", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetVLRenewalInterval", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ClearProductKeyFromRegistry()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ClearProductKeyFromRegistry", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 AcquireGenuineTicket(System.String inServerUrl, System.String inTemplateId)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ServerUrl", inServerUrl, inServerUrl == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("TemplateId", inTemplateId, inTemplateId == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AcquireGenuineTicket", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ReArmWindows()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ReArmWindows", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ReArmApp(System.String inApplicationId)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ApplicationId", inApplicationId, inApplicationId == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ReArmApp", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 RefreshLicenseStatus()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RefreshLicenseStatus", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetKeyManagementServiceListeningPort(System.UInt32? inPortNumber)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPortNumber.HasValue)
                parameters.Add(CimMethodParameter.Create("PortNumber", inPortNumber.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("PortNumber", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetKeyManagementServiceListeningPort", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ClearKeyManagementServiceListeningPort()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ClearKeyManagementServiceListeningPort", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 DisableKeyManagementServiceDnsPublishing(System.Boolean? inDisablePublishing)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDisablePublishing.HasValue)
                parameters.Add(CimMethodParameter.Create("DisablePublishing", inDisablePublishing.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("DisablePublishing", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DisableKeyManagementServiceDnsPublishing", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 EnableKeyManagementServiceLowPriority(System.Boolean? inEnableLowPriority)
        {
            var parameters = new CimMethodParametersCollection();
            if (inEnableLowPriority.HasValue)
                parameters.Add(CimMethodParameter.Create("EnableLowPriority", inEnableLowPriority.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("EnableLowPriority", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "EnableKeyManagementServiceLowPriority", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 DisableKeyManagementServiceHostCaching(System.Boolean? inDisableCaching)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDisableCaching.HasValue)
                parameters.Add(CimMethodParameter.Create("DisableCaching", inDisableCaching.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("DisableCaching", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DisableKeyManagementServiceHostCaching", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, System.String outInstallationID) GenerateActiveDirectoryOfflineActivationId(System.String inProductKey)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ProductKey", inProductKey, inProductKey == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GenerateActiveDirectoryOfflineActivationId", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["InstallationID"].Value);
        }

        public System.UInt32 DepositActiveDirectoryOfflineActivationConfirmation(System.String inActivationObjectName, System.String inConfirmationID, System.String inProductKey)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ActivationObjectName", inActivationObjectName, inActivationObjectName == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ConfirmationID", inConfirmationID, inConfirmationID == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ProductKey", inProductKey, inProductKey == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DepositActiveDirectoryOfflineActivationConfirmation", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 DoActiveDirectoryOnlineActivation(System.String inActivationObjectName, System.String inProductKey)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ActivationObjectName", inActivationObjectName, inActivationObjectName == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ProductKey", inProductKey, inProductKey == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DoActiveDirectoryOnlineActivation", parameters);
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
    }
}