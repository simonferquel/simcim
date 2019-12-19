using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetTeredoConfiguration : MSFTNetSettingData
    {
        public MSFTNetTeredoConfiguration()
        {
        }

        public MSFTNetTeredoConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ClientPort
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ClientPort", out result);
                return result;
            }

            set
            {
                this.SetProperty("ClientPort", value);
            }
        }

        public System.Boolean? DefaultQualified
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DefaultQualified", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefaultQualified", value);
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

        public System.UInt32? RefreshInterval
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RefreshInterval", out result);
                return result;
            }

            set
            {
                this.SetProperty("RefreshInterval", value);
            }
        }

        public System.String ServerName
        {
            get
            {
                System.String result;
                this.GetProperty("ServerName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServerName", value);
            }
        }

        public System.Boolean? ServerShunt
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ServerShunt", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServerShunt", value);
            }
        }

        public System.String ServerVirtualIP
        {
            get
            {
                System.String result;
                this.GetProperty("ServerVirtualIP", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServerVirtualIP", value);
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

        public (System.UInt32 retval, MSFTNetTeredoConfiguration outOutputObject) Reset(System.Boolean? inClientPort, System.Boolean? inDefaultQualified, System.Boolean? inPassThru, System.Boolean? inRefreshInterval, System.Boolean? inServerName, System.Boolean? inServerShunt, System.Boolean? inServerVirtualIP, System.Boolean? inType)
        {
            var parameters = new CimMethodParametersCollection();
            if (inClientPort.HasValue)
                parameters.Add(CimMethodParameter.Create("ClientPort", inClientPort.Value, CimFlags.None));
            if (inDefaultQualified.HasValue)
                parameters.Add(CimMethodParameter.Create("DefaultQualified", inDefaultQualified.Value, CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            if (inRefreshInterval.HasValue)
                parameters.Add(CimMethodParameter.Create("RefreshInterval", inRefreshInterval.Value, CimFlags.None));
            if (inServerName.HasValue)
                parameters.Add(CimMethodParameter.Create("ServerName", inServerName.Value, CimFlags.None));
            if (inServerShunt.HasValue)
                parameters.Add(CimMethodParameter.Create("ServerShunt", inServerShunt.Value, CimFlags.None));
            if (inServerVirtualIP.HasValue)
                parameters.Add(CimMethodParameter.Create("ServerVirtualIP", inServerVirtualIP.Value, CimFlags.None));
            if (inType.HasValue)
                parameters.Add(CimMethodParameter.Create("Type", inType.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Reset", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetTeredoConfiguration)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["OutputObject"].Value));
        }
    }
}