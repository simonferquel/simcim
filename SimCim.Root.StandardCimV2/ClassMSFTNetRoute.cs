using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetRoute : CIMNextHopRoute
    {
        public MSFTNetRoute()
        {
        }

        public MSFTNetRoute(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AddressFamily
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AddressFamily", out result);
                return result;
            }
        }

        public System.UInt32? CompartmentId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CompartmentId", out result);
                return result;
            }
        }

        public System.String DestinationPrefix
        {
            get
            {
                System.String result;
                this.GetProperty("DestinationPrefix", out result);
                return result;
            }
        }

        public System.String InterfaceAlias
        {
            get
            {
                System.String result;
                this.GetProperty("InterfaceAlias", out result);
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

        public System.UInt32? InterfaceMetric
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterfaceMetric", out result);
                return result;
            }
        }

        public System.String NextHop
        {
            get
            {
                System.String result;
                this.GetProperty("NextHop", out result);
                return result;
            }
        }

        public System.DateTime? PreferredLifetime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("PreferredLifetime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PreferredLifetime", value);
            }
        }

        public System.UInt16? Protocol
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Protocol", out result);
                return result;
            }
        }

        public System.Byte? Publish
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Publish", out result);
                return result;
            }

            set
            {
                this.SetProperty("Publish", value);
            }
        }

        public System.Byte? State
        {
            get
            {
                System.Byte? result;
                this.GetProperty("State", out result);
                return result;
            }
        }

        public System.Byte? Store
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Store", out result);
                return result;
            }
        }

        public System.DateTime? ValidLifetime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("ValidLifetime", out result);
                return result;
            }

            set
            {
                this.SetProperty("ValidLifetime", value);
            }
        }

        public (System.UInt32 retval, IEnumerable<MSFTNetRoute> outCmdletOutput) Create(System.UInt16? inAddressFamily, System.UInt32? inCompartmentId, System.String inDestinationPrefix, System.String inInterfaceAlias, System.UInt32? inInterfaceIndex, System.String inNextHop, System.Boolean? inPassThru, System.String inPolicyStore, System.DateTime? inPreferredLifetime, System.UInt16? inProtocol, System.Byte? inPublish, System.UInt16? inRouteMetric, System.DateTime? inValidLifetime)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAddressFamily.HasValue)
                parameters.Add(CimMethodParameter.Create("AddressFamily", inAddressFamily.Value, CimFlags.None));
            if (inCompartmentId.HasValue)
                parameters.Add(CimMethodParameter.Create("CompartmentId", inCompartmentId.Value, CimFlags.None));
            if (inDestinationPrefix != null)
                parameters.Add(CimMethodParameter.Create("DestinationPrefix", inDestinationPrefix, CimType.String, inDestinationPrefix == null ? CimFlags.NullValue : CimFlags.None));
            if (inInterfaceAlias != null)
                parameters.Add(CimMethodParameter.Create("InterfaceAlias", inInterfaceAlias, CimType.String, inInterfaceAlias == null ? CimFlags.NullValue : CimFlags.None));
            if (inInterfaceIndex.HasValue)
                parameters.Add(CimMethodParameter.Create("InterfaceIndex", inInterfaceIndex.Value, CimFlags.None));
            if (inNextHop != null)
                parameters.Add(CimMethodParameter.Create("NextHop", inNextHop, CimType.String, inNextHop == null ? CimFlags.NullValue : CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            if (inPolicyStore != null)
                parameters.Add(CimMethodParameter.Create("PolicyStore", inPolicyStore, CimType.String, inPolicyStore == null ? CimFlags.NullValue : CimFlags.None));
            if (inPreferredLifetime.HasValue)
                parameters.Add(CimMethodParameter.Create("PreferredLifetime", inPreferredLifetime.Value, CimFlags.None));
            if (inProtocol.HasValue)
                parameters.Add(CimMethodParameter.Create("Protocol", inProtocol.Value, CimFlags.None));
            if (inPublish.HasValue)
                parameters.Add(CimMethodParameter.Create("Publish", inPublish.Value, CimFlags.None));
            if (inRouteMetric.HasValue)
                parameters.Add(CimMethodParameter.Create("RouteMetric", inRouteMetric.Value, CimFlags.None));
            if (inValidLifetime.HasValue)
                parameters.Add(CimMethodParameter.Create("ValidLifetime", inValidLifetime.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Create", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<MSFTNetRoute>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["CmdletOutput"].Value));
        }

        public (System.UInt32 retval, IEnumerable<CIMManagedElement> outCmdletOutput) Find(System.UInt32? inInterfaceIndex, System.String inLocalIPAddress, System.String inRemoteIPAddress)
        {
            var parameters = new CimMethodParametersCollection();
            if (inInterfaceIndex.HasValue)
                parameters.Add(CimMethodParameter.Create("InterfaceIndex", inInterfaceIndex.Value, CimFlags.None));
            if (inLocalIPAddress != null)
                parameters.Add(CimMethodParameter.Create("LocalIPAddress", inLocalIPAddress, CimType.String, inLocalIPAddress == null ? CimFlags.NullValue : CimFlags.None));
            if (inRemoteIPAddress != null)
                parameters.Add(CimMethodParameter.Create("RemoteIPAddress", inRemoteIPAddress, CimType.String, inRemoteIPAddress == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Find", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<CIMManagedElement>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["CmdletOutput"].Value));
        }
    }
}