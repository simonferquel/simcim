using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAddressFilter : CIMFilterEntryBase
    {
        public MSFTNetAddressFilter()
        {
        }

        public MSFTNetAddressFilter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] LocalAddress
        {
            get
            {
                System.String[] result;
                this.GetProperty("LocalAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalAddress", value);
            }
        }

        public System.String[] RemoteAddress
        {
            get
            {
                System.String[] result;
                this.GetProperty("RemoteAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteAddress", value);
            }
        }

        public (System.UInt32 retval, System.UInt32? outIsolationType) QueryIsolationType(System.UInt32? inInterfaceIndex, System.String inRemoteAddress)
        {
            var parameters = new CimMethodParametersCollection();
            if (inInterfaceIndex.HasValue)
                parameters.Add(CimMethodParameter.Create("InterfaceIndex", inInterfaceIndex.Value, CimFlags.None));
            if (inRemoteAddress != null)
                parameters.Add(CimMethodParameter.Create("RemoteAddress", inRemoteAddress, CimType.String, inRemoteAddress == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "QueryIsolationType", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.UInt32? )result.OutParameters["IsolationType"].Value);
        }
    }
}