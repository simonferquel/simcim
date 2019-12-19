using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTDASiteTableEntry : MSFTNetSettingData
    {
        public MSFTDASiteTableEntry()
        {
        }

        public MSFTDASiteTableEntry(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ADSite
        {
            get
            {
                System.String result;
                this.GetProperty("ADSite", out result);
                return result;
            }

            set
            {
                this.SetProperty("ADSite", value);
            }
        }

        public System.String EntryPointIPAddress
        {
            get
            {
                System.String result;
                this.GetProperty("EntryPointIPAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("EntryPointIPAddress", value);
            }
        }

        public System.String EntryPointName
        {
            get
            {
                System.String result;
                this.GetProperty("EntryPointName", out result);
                return result;
            }
        }

        public System.String[] EntryPointRange
        {
            get
            {
                System.String[] result;
                this.GetProperty("EntryPointRange", out result);
                return result;
            }

            set
            {
                this.SetProperty("EntryPointRange", value);
            }
        }

        public System.String GslbIP
        {
            get
            {
                System.String result;
                this.GetProperty("GslbIP", out result);
                return result;
            }

            set
            {
                this.SetProperty("GslbIP", value);
            }
        }

        public System.String IPHttpsProfile
        {
            get
            {
                System.String result;
                this.GetProperty("IPHttpsProfile", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPHttpsProfile", value);
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

        public System.String TeredoServerIP
        {
            get
            {
                System.String result;
                this.GetProperty("TeredoServerIP", out result);
                return result;
            }

            set
            {
                this.SetProperty("TeredoServerIP", value);
            }
        }

        public System.UInt32 Enable(System.String inEntryPointName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inEntryPointName != null)
                parameters.Add(CimMethodParameter.Create("EntryPointName", inEntryPointName, CimType.String, inEntryPointName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Disable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, MSFTDASiteTableEntry outOutputObject) Rename(System.String inNewName, System.Boolean? inPassThru)
        {
            var parameters = new CimMethodParametersCollection();
            if (inNewName != null)
                parameters.Add(CimMethodParameter.Create("NewName", inNewName, CimType.String, inNewName == null ? CimFlags.NullValue : CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Rename", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTDASiteTableEntry)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["OutputObject"].Value));
        }

        public (System.UInt32 retval, MSFTDASiteTableEntry outOutputObject) Reset(System.Boolean? inGslbIP, System.Boolean? inIPHttpsProfile, System.Boolean? inPassThru, System.Boolean? inTeredoServerIP)
        {
            var parameters = new CimMethodParametersCollection();
            if (inGslbIP.HasValue)
                parameters.Add(CimMethodParameter.Create("GslbIP", inGslbIP.Value, CimFlags.None));
            if (inIPHttpsProfile.HasValue)
                parameters.Add(CimMethodParameter.Create("IPHttpsProfile", inIPHttpsProfile.Value, CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            if (inTeredoServerIP.HasValue)
                parameters.Add(CimMethodParameter.Create("TeredoServerIP", inTeredoServerIP.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Reset", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTDASiteTableEntry)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["OutputObject"].Value));
        }
    }
}