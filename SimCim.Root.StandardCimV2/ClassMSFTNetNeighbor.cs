using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetNeighbor : CIMRemoteServiceAccessPoint
    {
        public MSFTNetNeighbor()
        {
        }

        public MSFTNetNeighbor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.String IPAddress
        {
            get
            {
                System.String result;
                this.GetProperty("IPAddress", out result);
                return result;
            }
        }

        public System.String LinkLayerAddress
        {
            get
            {
                System.String result;
                this.GetProperty("LinkLayerAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("LinkLayerAddress", value);
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

        public (System.UInt32 retval, IEnumerable<MSFTNetNeighbor> outCmdletOutput) Create(System.UInt16? inAddressFamily, System.String inInterfaceAlias, System.UInt32? inInterfaceIndex, System.String inIPAddress, System.String inLinkLayerAddress, System.Boolean? inPassThru, System.String inPolicyStore, System.Byte? inState)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAddressFamily.HasValue)
                parameters.Add(CimMethodParameter.Create("AddressFamily", inAddressFamily.Value, CimFlags.None));
            if (inInterfaceAlias != null)
                parameters.Add(CimMethodParameter.Create("InterfaceAlias", inInterfaceAlias, CimType.String, inInterfaceAlias == null ? CimFlags.NullValue : CimFlags.None));
            if (inInterfaceIndex.HasValue)
                parameters.Add(CimMethodParameter.Create("InterfaceIndex", inInterfaceIndex.Value, CimFlags.None));
            if (inIPAddress != null)
                parameters.Add(CimMethodParameter.Create("IPAddress", inIPAddress, CimType.String, inIPAddress == null ? CimFlags.NullValue : CimFlags.None));
            if (inLinkLayerAddress != null)
                parameters.Add(CimMethodParameter.Create("LinkLayerAddress", inLinkLayerAddress, CimType.String, inLinkLayerAddress == null ? CimFlags.NullValue : CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            if (inPolicyStore != null)
                parameters.Add(CimMethodParameter.Create("PolicyStore", inPolicyStore, CimType.String, inPolicyStore == null ? CimFlags.NullValue : CimFlags.None));
            if (inState.HasValue)
                parameters.Add(CimMethodParameter.Create("State", inState.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Create", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<MSFTNetNeighbor>)InfrastuctureObjectScope.Mapper.CreateMany<MSFTNetNeighbor>(InfrastuctureObjectScope, (IEnumerable<CimInstance>)result.OutParameters["CmdletOutput"].Value));
        }
    }
}