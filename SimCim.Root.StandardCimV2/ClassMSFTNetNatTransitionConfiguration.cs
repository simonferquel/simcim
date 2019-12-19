using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetNatTransitionConfiguration : MSFTNetSettingData
    {
        public MSFTNetNatTransitionConfiguration()
        {
        }

        public MSFTNetNatTransitionConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] InboundInterface
        {
            get
            {
                System.String[] result;
                this.GetProperty("InboundInterface", out result);
                return result;
            }

            set
            {
                this.SetProperty("InboundInterface", value);
            }
        }

        public System.String InstanceName
        {
            get
            {
                System.String result;
                this.GetProperty("InstanceName", out result);
                return result;
            }
        }

        public System.String[] IPv4AddressPortPool
        {
            get
            {
                System.String[] result;
                this.GetProperty("IPv4AddressPortPool", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv4AddressPortPool", value);
            }
        }

        public System.String[] OutboundInterface
        {
            get
            {
                System.String[] result;
                this.GetProperty("OutboundInterface", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutboundInterface", value);
            }
        }

        public System.UInt32? PolicyStore
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PolicyStore", out result);
                return result;
            }

            set
            {
                this.SetProperty("PolicyStore", value);
            }
        }

        public System.String[] PrefixMapping
        {
            get
            {
                System.String[] result;
                this.GetProperty("PrefixMapping", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrefixMapping", value);
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

        public System.UInt32? TcpMappingTimeout
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TcpMappingTimeout", out result);
                return result;
            }

            set
            {
                this.SetProperty("TcpMappingTimeout", value);
            }
        }

        public (System.UInt32 retval, MSFTNetNatTransitionConfiguration outOutputObject) Enable(System.Boolean? inPassThru)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetNatTransitionConfiguration)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["OutputObject"].Value));
        }

        public (System.UInt32 retval, MSFTNetNatTransitionConfiguration outOutputObject) Disable(System.Boolean? inPassThru)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetNatTransitionConfiguration)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["OutputObject"].Value));
        }
    }
}