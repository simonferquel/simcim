using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetConSecRule : MSFTNetSARule
    {
        public MSFTNetConSecRule()
        {
        }

        public MSFTNetConSecRule(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AllowSetKey
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AllowSetKey", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowSetKey", value);
            }
        }

        public System.Boolean? AllowWatchKey
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AllowWatchKey", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowWatchKey", value);
            }
        }

        public System.Boolean? BypassTunnelIfEncrypted
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("BypassTunnelIfEncrypted", out result);
                return result;
            }

            set
            {
                this.SetProperty("BypassTunnelIfEncrypted", value);
            }
        }

        public System.UInt16? InboundSecurity
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("InboundSecurity", out result);
                return result;
            }

            set
            {
                this.SetProperty("InboundSecurity", value);
            }
        }

        public System.UInt16? KeyModule
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("KeyModule", out result);
                return result;
            }

            set
            {
                this.SetProperty("KeyModule", value);
            }
        }

        public System.String[] LocalTunnelEndpoint
        {
            get
            {
                System.String[] result;
                this.GetProperty("LocalTunnelEndpoint", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalTunnelEndpoint", value);
            }
        }

        public System.String Machines
        {
            get
            {
                System.String result;
                this.GetProperty("Machines", out result);
                return result;
            }

            set
            {
                this.SetProperty("Machines", value);
            }
        }

        public System.UInt32? MaxReturnPathLifetimeSeconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxReturnPathLifetimeSeconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxReturnPathLifetimeSeconds", value);
            }
        }

        public System.UInt16? Mode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Mode", out result);
                return result;
            }

            set
            {
                this.SetProperty("Mode", value);
            }
        }

        public System.UInt16? OutboundSecurity
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("OutboundSecurity", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutboundSecurity", value);
            }
        }

        public System.String[] RemoteTunnelEndpoint
        {
            get
            {
                System.String[] result;
                this.GetProperty("RemoteTunnelEndpoint", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteTunnelEndpoint", value);
            }
        }

        public System.String RemoteTunnelEndpointDNSName
        {
            get
            {
                System.String result;
                this.GetProperty("RemoteTunnelEndpointDNSName", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteTunnelEndpointDNSName", value);
            }
        }

        public System.Boolean? RequireAuthorization
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RequireAuthorization", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequireAuthorization", value);
            }
        }

        public System.String Users
        {
            get
            {
                System.String result;
                this.GetProperty("Users", out result);
                return result;
            }

            set
            {
                this.SetProperty("Users", value);
            }
        }

        public (System.UInt32 retval, IEnumerable<MSFTNetSecDeltaCollection> outOutput) SyncPolicyDelta(System.UInt16? inAddressType, System.String[] inDnsServers, System.String[] inDomains, System.UInt16? inEndpointType, System.String[] inServers)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAddressType.HasValue)
                parameters.Add(CimMethodParameter.Create("AddressType", inAddressType.Value, CimFlags.None));
            if (inDnsServers != null)
                parameters.Add(CimMethodParameter.Create("DnsServers", inDnsServers, CimType.StringArray, inDnsServers == null ? CimFlags.NullValue : CimFlags.None));
            if (inDomains != null)
                parameters.Add(CimMethodParameter.Create("Domains", inDomains, CimType.StringArray, inDomains == null ? CimFlags.NullValue : CimFlags.None));
            if (inEndpointType.HasValue)
                parameters.Add(CimMethodParameter.Create("EndpointType", inEndpointType.Value, CimFlags.None));
            if (inServers != null)
                parameters.Add(CimMethodParameter.Create("Servers", inServers, CimType.StringArray, inServers == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SyncPolicyDelta", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<MSFTNetSecDeltaCollection>)InfrastuctureObjectScope.Mapper.CreateMany<MSFTNetSecDeltaCollection>(InfrastuctureObjectScope, (IEnumerable<CimInstance>)result.OutParameters["Output"].Value));
        }

        public (System.UInt32 retval, IEnumerable<MSFTNetConSecRule> outOutput) SetPolicyDelta(System.UInt16? inAction, System.UInt16? inEndpointType, System.String[] inIPv4Addresses, System.String[] inIPv6Addresses, System.Boolean? inPassThru)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAction.HasValue)
                parameters.Add(CimMethodParameter.Create("Action", inAction.Value, CimFlags.None));
            if (inEndpointType.HasValue)
                parameters.Add(CimMethodParameter.Create("EndpointType", inEndpointType.Value, CimFlags.None));
            if (inIPv4Addresses != null)
                parameters.Add(CimMethodParameter.Create("IPv4Addresses", inIPv4Addresses, CimType.StringArray, inIPv4Addresses == null ? CimFlags.NullValue : CimFlags.None));
            if (inIPv6Addresses != null)
                parameters.Add(CimMethodParameter.Create("IPv6Addresses", inIPv6Addresses, CimType.StringArray, inIPv6Addresses == null ? CimFlags.NullValue : CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetPolicyDelta", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<MSFTNetConSecRule>)InfrastuctureObjectScope.Mapper.CreateMany<MSFTNetConSecRule>(InfrastuctureObjectScope, (IEnumerable<CimInstance>)result.OutParameters["Output"].Value));
        }

        public (System.UInt32 retval, IEnumerable<CIMManagedSystemElement> outDependents) EnumerateFull()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "EnumerateFull", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<CIMManagedSystemElement>)InfrastuctureObjectScope.Mapper.CreateMany<CIMManagedSystemElement>(InfrastuctureObjectScope, (IEnumerable<CimInstance>)result.OutParameters["Dependents"].Value));
        }

        public (System.UInt32 retval, IEnumerable<MSFTNetConSecRule> outCmdletOutput) Find(System.String inLocalAddress, System.UInt16? inLocalPort, System.String inProtocol, System.String inRemoteAddress, System.UInt16? inRemotePort)
        {
            var parameters = new CimMethodParametersCollection();
            if (inLocalAddress != null)
                parameters.Add(CimMethodParameter.Create("LocalAddress", inLocalAddress, CimType.String, inLocalAddress == null ? CimFlags.NullValue : CimFlags.None));
            if (inLocalPort.HasValue)
                parameters.Add(CimMethodParameter.Create("LocalPort", inLocalPort.Value, CimFlags.None));
            if (inProtocol != null)
                parameters.Add(CimMethodParameter.Create("Protocol", inProtocol, CimType.String, inProtocol == null ? CimFlags.NullValue : CimFlags.None));
            if (inRemoteAddress != null)
                parameters.Add(CimMethodParameter.Create("RemoteAddress", inRemoteAddress, CimType.String, inRemoteAddress == null ? CimFlags.NullValue : CimFlags.None));
            if (inRemotePort.HasValue)
                parameters.Add(CimMethodParameter.Create("RemotePort", inRemotePort.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Find", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<MSFTNetConSecRule>)InfrastuctureObjectScope.Mapper.CreateMany<MSFTNetConSecRule>(InfrastuctureObjectScope, (IEnumerable<CimInstance>)result.OutParameters["CmdletOutput"].Value));
        }

        public System.UInt32 Enable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Disable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Rename(System.String inNewName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inNewName != null)
                parameters.Add(CimMethodParameter.Create("NewName", inNewName, CimType.String, inNewName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Rename", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 CloneObject(System.String inNewGPOSession, System.String inNewName, System.String inNewPolicyStore)
        {
            var parameters = new CimMethodParametersCollection();
            if (inNewGPOSession != null)
                parameters.Add(CimMethodParameter.Create("NewGPOSession", inNewGPOSession, CimType.String, inNewGPOSession == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewName != null)
                parameters.Add(CimMethodParameter.Create("NewName", inNewName, CimType.String, inNewName == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewPolicyStore != null)
                parameters.Add(CimMethodParameter.Create("NewPolicyStore", inNewPolicyStore, CimType.String, inNewPolicyStore == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CloneObject", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}