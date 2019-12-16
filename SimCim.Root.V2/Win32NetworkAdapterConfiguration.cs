using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NetworkAdapterConfiguration : CIMSetting
    {
        public Win32NetworkAdapterConfiguration()
        {
        }

        public Win32NetworkAdapterConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? ArpAlwaysSourceRoute
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ArpAlwaysSourceRoute", out result);
                return result;
            }
        }

        public System.Boolean? ArpUseEtherSNAP
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ArpUseEtherSNAP", out result);
                return result;
            }
        }

        public System.String DatabasePath
        {
            get
            {
                System.String result;
                this.GetProperty("DatabasePath", out result);
                return result;
            }
        }

        public System.Boolean? DeadGWDetectEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DeadGWDetectEnabled", out result);
                return result;
            }
        }

        public System.String[] DefaultIPGateway
        {
            get
            {
                System.String[] result;
                this.GetProperty("DefaultIPGateway", out result);
                return result;
            }
        }

        public System.Byte? DefaultTOS
        {
            get
            {
                System.Byte? result;
                this.GetProperty("DefaultTOS", out result);
                return result;
            }
        }

        public System.Byte? DefaultTTL
        {
            get
            {
                System.Byte? result;
                this.GetProperty("DefaultTTL", out result);
                return result;
            }
        }

        public System.Boolean? DHCPEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DHCPEnabled", out result);
                return result;
            }
        }

        public System.DateTime? DHCPLeaseExpires
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("DHCPLeaseExpires", out result);
                return result;
            }
        }

        public System.DateTime? DHCPLeaseObtained
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("DHCPLeaseObtained", out result);
                return result;
            }
        }

        public System.String DHCPServer
        {
            get
            {
                System.String result;
                this.GetProperty("DHCPServer", out result);
                return result;
            }
        }

        public System.String DNSDomain
        {
            get
            {
                System.String result;
                this.GetProperty("DNSDomain", out result);
                return result;
            }
        }

        public System.String[] DNSDomainSuffixSearchOrder
        {
            get
            {
                System.String[] result;
                this.GetProperty("DNSDomainSuffixSearchOrder", out result);
                return result;
            }
        }

        public System.Boolean? DNSEnabledForWINSResolution
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DNSEnabledForWINSResolution", out result);
                return result;
            }
        }

        public System.String DNSHostName
        {
            get
            {
                System.String result;
                this.GetProperty("DNSHostName", out result);
                return result;
            }
        }

        public System.String[] DNSServerSearchOrder
        {
            get
            {
                System.String[] result;
                this.GetProperty("DNSServerSearchOrder", out result);
                return result;
            }
        }

        public System.Boolean? DomainDNSRegistrationEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DomainDNSRegistrationEnabled", out result);
                return result;
            }
        }

        public System.UInt32? ForwardBufferMemory
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ForwardBufferMemory", out result);
                return result;
            }
        }

        public System.Boolean? FullDNSRegistrationEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("FullDNSRegistrationEnabled", out result);
                return result;
            }
        }

        public System.UInt16[] GatewayCostMetric
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("GatewayCostMetric", out result);
                return result;
            }
        }

        public System.Byte? IGMPLevel
        {
            get
            {
                System.Byte? result;
                this.GetProperty("IGMPLevel", out result);
                return result;
            }
        }

        public System.UInt32 Index
        {
            get
            {
                System.UInt32 result;
                this.GetProperty("Index", out result);
                return result;
            }
        }

        public System.UInt32? InterfaceIndex
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterfaceIndex", out result);
                return result;
            }
        }

        public System.String[] IPAddress
        {
            get
            {
                System.String[] result;
                this.GetProperty("IPAddress", out result);
                return result;
            }
        }

        public System.UInt32? IPConnectionMetric
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPConnectionMetric", out result);
                return result;
            }
        }

        public System.Boolean? IPEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPEnabled", out result);
                return result;
            }
        }

        public System.Boolean? IPFilterSecurityEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPFilterSecurityEnabled", out result);
                return result;
            }
        }

        public System.Boolean? IPPortSecurityEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPPortSecurityEnabled", out result);
                return result;
            }
        }

        public System.String[] IPSecPermitIPProtocols
        {
            get
            {
                System.String[] result;
                this.GetProperty("IPSecPermitIPProtocols", out result);
                return result;
            }
        }

        public System.String[] IPSecPermitTCPPorts
        {
            get
            {
                System.String[] result;
                this.GetProperty("IPSecPermitTCPPorts", out result);
                return result;
            }
        }

        public System.String[] IPSecPermitUDPPorts
        {
            get
            {
                System.String[] result;
                this.GetProperty("IPSecPermitUDPPorts", out result);
                return result;
            }
        }

        public System.String[] IPSubnet
        {
            get
            {
                System.String[] result;
                this.GetProperty("IPSubnet", out result);
                return result;
            }
        }

        public System.Boolean? IPUseZeroBroadcast
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPUseZeroBroadcast", out result);
                return result;
            }
        }

        public System.String IPXAddress
        {
            get
            {
                System.String result;
                this.GetProperty("IPXAddress", out result);
                return result;
            }
        }

        public System.Boolean? IPXEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPXEnabled", out result);
                return result;
            }
        }

        public System.UInt32[] IPXFrameType
        {
            get
            {
                System.UInt32[] result;
                this.GetProperty("IPXFrameType", out result);
                return result;
            }
        }

        public System.UInt32? IPXMediaType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPXMediaType", out result);
                return result;
            }
        }

        public System.String[] IPXNetworkNumber
        {
            get
            {
                System.String[] result;
                this.GetProperty("IPXNetworkNumber", out result);
                return result;
            }
        }

        public System.String IPXVirtualNetNumber
        {
            get
            {
                System.String result;
                this.GetProperty("IPXVirtualNetNumber", out result);
                return result;
            }
        }

        public System.UInt32? KeepAliveInterval
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KeepAliveInterval", out result);
                return result;
            }
        }

        public System.UInt32? KeepAliveTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KeepAliveTime", out result);
                return result;
            }
        }

        public System.String MACAddress
        {
            get
            {
                System.String result;
                this.GetProperty("MACAddress", out result);
                return result;
            }
        }

        public System.UInt32? MTU
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MTU", out result);
                return result;
            }
        }

        public System.UInt32? NumForwardPackets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumForwardPackets", out result);
                return result;
            }
        }

        public System.Boolean? PMTUBHDetectEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PMTUBHDetectEnabled", out result);
                return result;
            }
        }

        public System.Boolean? PMTUDiscoveryEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PMTUDiscoveryEnabled", out result);
                return result;
            }
        }

        public System.String ServiceName
        {
            get
            {
                System.String result;
                this.GetProperty("ServiceName", out result);
                return result;
            }
        }

        public System.UInt32? TcpipNetbiosOptions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TcpipNetbiosOptions", out result);
                return result;
            }
        }

        public System.UInt32? TcpMaxConnectRetransmissions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TcpMaxConnectRetransmissions", out result);
                return result;
            }
        }

        public System.UInt32? TcpMaxDataRetransmissions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TcpMaxDataRetransmissions", out result);
                return result;
            }
        }

        public System.UInt32? TcpNumConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TcpNumConnections", out result);
                return result;
            }
        }

        public System.Boolean? TcpUseRFC1122UrgentPointer
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("TcpUseRFC1122UrgentPointer", out result);
                return result;
            }
        }

        public System.UInt16? TcpWindowSize
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TcpWindowSize", out result);
                return result;
            }
        }

        public System.Boolean? WINSEnableLMHostsLookup
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("WINSEnableLMHostsLookup", out result);
                return result;
            }
        }

        public System.String WINSHostLookupFile
        {
            get
            {
                System.String result;
                this.GetProperty("WINSHostLookupFile", out result);
                return result;
            }
        }

        public System.String WINSPrimaryServer
        {
            get
            {
                System.String result;
                this.GetProperty("WINSPrimaryServer", out result);
                return result;
            }
        }

        public System.String WINSScopeID
        {
            get
            {
                System.String result;
                this.GetProperty("WINSScopeID", out result);
                return result;
            }
        }

        public System.String WINSSecondaryServer
        {
            get
            {
                System.String result;
                this.GetProperty("WINSSecondaryServer", out result);
                return result;
            }
        }

        public System.UInt32 EnableDHCP()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "EnableDHCP", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 RenewDHCPLease()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RenewDHCPLease", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 RenewDHCPLeaseAll()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RenewDHCPLeaseAll", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ReleaseDHCPLease()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ReleaseDHCPLease", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ReleaseDHCPLeaseAll()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ReleaseDHCPLeaseAll", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 EnableStatic(System.String[] inIPAddress, System.String[] inSubnetMask)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("IPAddress", inIPAddress, CimType.StringArray, inIPAddress == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("SubnetMask", inSubnetMask, CimType.StringArray, inSubnetMask == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "EnableStatic", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetGateways(System.String[] inDefaultIPGateway, System.UInt16[] inGatewayCostMetric)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("DefaultIPGateway", inDefaultIPGateway, CimType.StringArray, inDefaultIPGateway == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("GatewayCostMetric", inGatewayCostMetric, CimType.UInt16Array, inGatewayCostMetric == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetGateways", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 EnableDNS(System.String inDNSDomain, System.String[] inDNSDomainSuffixSearchOrder, System.String inDNSHostName, System.String[] inDNSServerSearchOrder)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("DNSDomain", inDNSDomain, CimType.String, inDNSDomain == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("DNSDomainSuffixSearchOrder", inDNSDomainSuffixSearchOrder, CimType.StringArray, inDNSDomainSuffixSearchOrder == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("DNSHostName", inDNSHostName, CimType.String, inDNSHostName == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("DNSServerSearchOrder", inDNSServerSearchOrder, CimType.StringArray, inDNSServerSearchOrder == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "EnableDNS", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetDNSDomain(System.String inDNSDomain)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("DNSDomain", inDNSDomain, CimType.String, inDNSDomain == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetDNSDomain", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetDNSServerSearchOrder(System.String[] inDNSServerSearchOrder)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("DNSServerSearchOrder", inDNSServerSearchOrder, CimType.StringArray, inDNSServerSearchOrder == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetDNSServerSearchOrder", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetDNSSuffixSearchOrder(System.String[] inDNSDomainSuffixSearchOrder)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("DNSDomainSuffixSearchOrder", inDNSDomainSuffixSearchOrder, CimType.StringArray, inDNSDomainSuffixSearchOrder == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetDNSSuffixSearchOrder", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetDynamicDNSRegistration(System.Boolean? inDomainDNSRegistrationEnabled, System.Boolean? inFullDNSRegistrationEnabled)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDomainDNSRegistrationEnabled.HasValue)
                parameters.Add(CimMethodParameter.Create("DomainDNSRegistrationEnabled", inDomainDNSRegistrationEnabled.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("DomainDNSRegistrationEnabled", null, CimFlags.NullValue));
            if (inFullDNSRegistrationEnabled.HasValue)
                parameters.Add(CimMethodParameter.Create("FullDNSRegistrationEnabled", inFullDNSRegistrationEnabled.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("FullDNSRegistrationEnabled", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetDynamicDNSRegistration", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetIPConnectionMetric(System.UInt32? inIPConnectionMetric)
        {
            var parameters = new CimMethodParametersCollection();
            if (inIPConnectionMetric.HasValue)
                parameters.Add(CimMethodParameter.Create("IPConnectionMetric", inIPConnectionMetric.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("IPConnectionMetric", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetIPConnectionMetric", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetWINSServer(System.String inWINSPrimaryServer, System.String inWINSSecondaryServer)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("WINSPrimaryServer", inWINSPrimaryServer, CimType.String, inWINSPrimaryServer == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("WINSSecondaryServer", inWINSSecondaryServer, CimType.String, inWINSSecondaryServer == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetWINSServer", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 EnableWINS(System.Boolean? inDNSEnabledForWINSResolution, System.Boolean? inWINSEnableLMHostsLookup, System.String inWINSHostLookupFile, System.String inWINSScopeID)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDNSEnabledForWINSResolution.HasValue)
                parameters.Add(CimMethodParameter.Create("DNSEnabledForWINSResolution", inDNSEnabledForWINSResolution.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("DNSEnabledForWINSResolution", null, CimFlags.NullValue));
            if (inWINSEnableLMHostsLookup.HasValue)
                parameters.Add(CimMethodParameter.Create("WINSEnableLMHostsLookup", inWINSEnableLMHostsLookup.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("WINSEnableLMHostsLookup", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("WINSHostLookupFile", inWINSHostLookupFile, CimType.String, inWINSHostLookupFile == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("WINSScopeID", inWINSScopeID, CimType.String, inWINSScopeID == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "EnableWINS", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetTcpipNetbios(System.UInt32? inTcpipNetbiosOptions)
        {
            var parameters = new CimMethodParametersCollection();
            if (inTcpipNetbiosOptions.HasValue)
                parameters.Add(CimMethodParameter.Create("TcpipNetbiosOptions", inTcpipNetbiosOptions.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("TcpipNetbiosOptions", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetTcpipNetbios", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 EnableIPSec(System.String[] inIPSecPermitIPProtocols, System.String[] inIPSecPermitTCPPorts, System.String[] inIPSecPermitUDPPorts)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("IPSecPermitIPProtocols", inIPSecPermitIPProtocols, CimType.StringArray, inIPSecPermitIPProtocols == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("IPSecPermitTCPPorts", inIPSecPermitTCPPorts, CimType.StringArray, inIPSecPermitTCPPorts == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("IPSecPermitUDPPorts", inIPSecPermitUDPPorts, CimType.StringArray, inIPSecPermitUDPPorts == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "EnableIPSec", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 DisableIPSec()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DisableIPSec", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetIPXVirtualNetworkNumber(System.String inIPXVirtualNetNumber)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("IPXVirtualNetNumber", inIPXVirtualNetNumber, CimType.String, inIPXVirtualNetNumber == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetIPXVirtualNetworkNumber", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetIPXFrameTypeNetworkPairs(System.UInt32[] inIPXFrameType, System.String[] inIPXNetworkNumber)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("IPXFrameType", inIPXFrameType, CimType.UInt32Array, inIPXFrameType == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("IPXNetworkNumber", inIPXNetworkNumber, CimType.StringArray, inIPXNetworkNumber == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetIPXFrameTypeNetworkPairs", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetDatabasePath(System.String inDatabasePath)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("DatabasePath", inDatabasePath, CimType.String, inDatabasePath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetDatabasePath", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetIPUseZeroBroadcast(System.Boolean? inIPUseZeroBroadcast)
        {
            var parameters = new CimMethodParametersCollection();
            if (inIPUseZeroBroadcast.HasValue)
                parameters.Add(CimMethodParameter.Create("IPUseZeroBroadcast", inIPUseZeroBroadcast.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("IPUseZeroBroadcast", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetIPUseZeroBroadcast", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetArpAlwaysSourceRoute(System.Boolean? inArpAlwaysSourceRoute)
        {
            var parameters = new CimMethodParametersCollection();
            if (inArpAlwaysSourceRoute.HasValue)
                parameters.Add(CimMethodParameter.Create("ArpAlwaysSourceRoute", inArpAlwaysSourceRoute.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ArpAlwaysSourceRoute", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetArpAlwaysSourceRoute", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetArpUseEtherSNAP(System.Boolean? inArpUseEtherSNAP)
        {
            var parameters = new CimMethodParametersCollection();
            if (inArpUseEtherSNAP.HasValue)
                parameters.Add(CimMethodParameter.Create("ArpUseEtherSNAP", inArpUseEtherSNAP.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ArpUseEtherSNAP", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetArpUseEtherSNAP", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetDefaultTOS(System.Byte? inDefaultTOS)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDefaultTOS.HasValue)
                parameters.Add(CimMethodParameter.Create("DefaultTOS", inDefaultTOS.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("DefaultTOS", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetDefaultTOS", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetDefaultTTL(System.Byte? inDefaultTTL)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDefaultTTL.HasValue)
                parameters.Add(CimMethodParameter.Create("DefaultTTL", inDefaultTTL.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("DefaultTTL", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetDefaultTTL", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetDeadGWDetect(System.Boolean? inDeadGWDetectEnabled)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDeadGWDetectEnabled.HasValue)
                parameters.Add(CimMethodParameter.Create("DeadGWDetectEnabled", inDeadGWDetectEnabled.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("DeadGWDetectEnabled", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetDeadGWDetect", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetPMTUBHDetect(System.Boolean? inPMTUBHDetectEnabled)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPMTUBHDetectEnabled.HasValue)
                parameters.Add(CimMethodParameter.Create("PMTUBHDetectEnabled", inPMTUBHDetectEnabled.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("PMTUBHDetectEnabled", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetPMTUBHDetect", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetPMTUDiscovery(System.Boolean? inPMTUDiscoveryEnabled)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPMTUDiscoveryEnabled.HasValue)
                parameters.Add(CimMethodParameter.Create("PMTUDiscoveryEnabled", inPMTUDiscoveryEnabled.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("PMTUDiscoveryEnabled", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetPMTUDiscovery", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetForwardBufferMemory(System.UInt32? inForwardBufferMemory)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForwardBufferMemory.HasValue)
                parameters.Add(CimMethodParameter.Create("ForwardBufferMemory", inForwardBufferMemory.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ForwardBufferMemory", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetForwardBufferMemory", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetIGMPLevel(System.Byte? inIGMPLevel)
        {
            var parameters = new CimMethodParametersCollection();
            if (inIGMPLevel.HasValue)
                parameters.Add(CimMethodParameter.Create("IGMPLevel", inIGMPLevel.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("IGMPLevel", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetIGMPLevel", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetKeepAliveInterval(System.UInt32? inKeepAliveInterval)
        {
            var parameters = new CimMethodParametersCollection();
            if (inKeepAliveInterval.HasValue)
                parameters.Add(CimMethodParameter.Create("KeepAliveInterval", inKeepAliveInterval.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("KeepAliveInterval", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetKeepAliveInterval", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetKeepAliveTime(System.UInt32? inKeepAliveTime)
        {
            var parameters = new CimMethodParametersCollection();
            if (inKeepAliveTime.HasValue)
                parameters.Add(CimMethodParameter.Create("KeepAliveTime", inKeepAliveTime.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("KeepAliveTime", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetKeepAliveTime", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetMTU(System.UInt32? inMTU)
        {
            var parameters = new CimMethodParametersCollection();
            if (inMTU.HasValue)
                parameters.Add(CimMethodParameter.Create("MTU", inMTU.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("MTU", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetMTU", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetNumForwardPackets(System.UInt32? inNumForwardPackets)
        {
            var parameters = new CimMethodParametersCollection();
            if (inNumForwardPackets.HasValue)
                parameters.Add(CimMethodParameter.Create("NumForwardPackets", inNumForwardPackets.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("NumForwardPackets", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetNumForwardPackets", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetTcpMaxConnectRetransmissions(System.UInt32? inTcpMaxConnectRetransmissions)
        {
            var parameters = new CimMethodParametersCollection();
            if (inTcpMaxConnectRetransmissions.HasValue)
                parameters.Add(CimMethodParameter.Create("TcpMaxConnectRetransmissions", inTcpMaxConnectRetransmissions.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("TcpMaxConnectRetransmissions", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetTcpMaxConnectRetransmissions", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetTcpMaxDataRetransmissions(System.UInt32? inTcpMaxDataRetransmissions)
        {
            var parameters = new CimMethodParametersCollection();
            if (inTcpMaxDataRetransmissions.HasValue)
                parameters.Add(CimMethodParameter.Create("TcpMaxDataRetransmissions", inTcpMaxDataRetransmissions.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("TcpMaxDataRetransmissions", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetTcpMaxDataRetransmissions", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetTcpNumConnections(System.UInt32? inTcpNumConnections)
        {
            var parameters = new CimMethodParametersCollection();
            if (inTcpNumConnections.HasValue)
                parameters.Add(CimMethodParameter.Create("TcpNumConnections", inTcpNumConnections.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("TcpNumConnections", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetTcpNumConnections", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetTcpUseRFC1122UrgentPointer(System.Boolean? inTcpUseRFC1122UrgentPointer)
        {
            var parameters = new CimMethodParametersCollection();
            if (inTcpUseRFC1122UrgentPointer.HasValue)
                parameters.Add(CimMethodParameter.Create("TcpUseRFC1122UrgentPointer", inTcpUseRFC1122UrgentPointer.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("TcpUseRFC1122UrgentPointer", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetTcpUseRFC1122UrgentPointer", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetTcpWindowSize(System.UInt16? inTcpWindowSize)
        {
            var parameters = new CimMethodParametersCollection();
            if (inTcpWindowSize.HasValue)
                parameters.Add(CimMethodParameter.Create("TcpWindowSize", inTcpWindowSize.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("TcpWindowSize", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetTcpWindowSize", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 EnableIPFilterSec(System.Boolean? inIPFilterSecurityEnabled)
        {
            var parameters = new CimMethodParametersCollection();
            if (inIPFilterSecurityEnabled.HasValue)
                parameters.Add(CimMethodParameter.Create("IPFilterSecurityEnabled", inIPFilterSecurityEnabled.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("IPFilterSecurityEnabled", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "EnableIPFilterSec", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public Win32NetworkAdapter ResolveWin32NetworkAdapterSettingElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_NetworkAdapterSetting", "Win32_NetworkAdapter", "Setting", "Element");
            return instances.Select(i => (Win32NetworkAdapter)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}