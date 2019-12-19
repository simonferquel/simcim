using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTDAClientExperienceConfiguration : MSFTNetSettingData
    {
        public MSFTDAClientExperienceConfiguration()
        {
        }

        public MSFTDAClientExperienceConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] CorporateResources
        {
            get
            {
                System.String[] result;
                this.GetProperty("CorporateResources", out result);
                return result;
            }

            set
            {
                this.SetProperty("CorporateResources", value);
            }
        }

        public System.String[] CustomCommands
        {
            get
            {
                System.String[] result;
                this.GetProperty("CustomCommands", out result);
                return result;
            }

            set
            {
                this.SetProperty("CustomCommands", value);
            }
        }

        public System.UInt32? ForceTunneling
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ForceTunneling", out result);
                return result;
            }

            set
            {
                this.SetProperty("ForceTunneling", value);
            }
        }

        public System.String FriendlyName
        {
            get
            {
                System.String result;
                this.GetProperty("FriendlyName", out result);
                return result;
            }

            set
            {
                this.SetProperty("FriendlyName", value);
            }
        }

        public System.String GslbFqdn
        {
            get
            {
                System.String result;
                this.GetProperty("GslbFqdn", out result);
                return result;
            }

            set
            {
                this.SetProperty("GslbFqdn", value);
            }
        }

        public System.String[] IPsecTunnelEndpoints
        {
            get
            {
                System.String[] result;
                this.GetProperty("IPsecTunnelEndpoints", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPsecTunnelEndpoints", value);
            }
        }

        public System.Boolean? ManualEntryPointSelectionAllowed
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ManualEntryPointSelectionAllowed", out result);
                return result;
            }

            set
            {
                this.SetProperty("ManualEntryPointSelectionAllowed", value);
            }
        }

        public System.Boolean? PassiveMode
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PassiveMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("PassiveMode", value);
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

        public System.Boolean? PreferLocalNamesAllowed
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PreferLocalNamesAllowed", out result);
                return result;
            }

            set
            {
                this.SetProperty("PreferLocalNamesAllowed", value);
            }
        }

        public System.String SupportEmail
        {
            get
            {
                System.String result;
                this.GetProperty("SupportEmail", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportEmail", value);
            }
        }

        public System.Boolean? UserInterface
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("UserInterface", out result);
                return result;
            }

            set
            {
                this.SetProperty("UserInterface", value);
            }
        }

        public (System.UInt32 retval, MSFTDAClientExperienceConfiguration outOutputObject) Reset(System.Boolean? inCorporateResources, System.Boolean? inCustomCommands, System.Boolean? inForceTunneling, System.Boolean? inFriendlyName, System.Boolean? inGslbFqdn, System.Boolean? inIPsecTunnelEndpoints, System.Boolean? inManualEntryPointSelectionAllowed, System.Boolean? inPassiveMode, System.Boolean? inPassThru, System.Boolean? inPreferLocalNamesAllowed, System.Boolean? inSupportEmail, System.Boolean? inUserInterface)
        {
            var parameters = new CimMethodParametersCollection();
            if (inCorporateResources.HasValue)
                parameters.Add(CimMethodParameter.Create("CorporateResources", inCorporateResources.Value, CimFlags.None));
            if (inCustomCommands.HasValue)
                parameters.Add(CimMethodParameter.Create("CustomCommands", inCustomCommands.Value, CimFlags.None));
            if (inForceTunneling.HasValue)
                parameters.Add(CimMethodParameter.Create("ForceTunneling", inForceTunneling.Value, CimFlags.None));
            if (inFriendlyName.HasValue)
                parameters.Add(CimMethodParameter.Create("FriendlyName", inFriendlyName.Value, CimFlags.None));
            if (inGslbFqdn.HasValue)
                parameters.Add(CimMethodParameter.Create("GslbFqdn", inGslbFqdn.Value, CimFlags.None));
            if (inIPsecTunnelEndpoints.HasValue)
                parameters.Add(CimMethodParameter.Create("IPsecTunnelEndpoints", inIPsecTunnelEndpoints.Value, CimFlags.None));
            if (inManualEntryPointSelectionAllowed.HasValue)
                parameters.Add(CimMethodParameter.Create("ManualEntryPointSelectionAllowed", inManualEntryPointSelectionAllowed.Value, CimFlags.None));
            if (inPassiveMode.HasValue)
                parameters.Add(CimMethodParameter.Create("PassiveMode", inPassiveMode.Value, CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            if (inPreferLocalNamesAllowed.HasValue)
                parameters.Add(CimMethodParameter.Create("PreferLocalNamesAllowed", inPreferLocalNamesAllowed.Value, CimFlags.None));
            if (inSupportEmail.HasValue)
                parameters.Add(CimMethodParameter.Create("SupportEmail", inSupportEmail.Value, CimFlags.None));
            if (inUserInterface.HasValue)
                parameters.Add(CimMethodParameter.Create("UserInterface", inUserInterface.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Reset", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTDAClientExperienceConfiguration)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["OutputObject"].Value));
        }
    }
}