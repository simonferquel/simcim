using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetTransportFilter : CIMFilterEntryBase
    {
        public MSFTNetTransportFilter()
        {
        }

        public MSFTNetTransportFilter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.UInt16? LocalPortEnd
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LocalPortEnd", out result);
                return result;
            }
        }

        public System.UInt16? LocalPortStart
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LocalPortStart", out result);
                return result;
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

        public System.UInt16? RemotePortEnd
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("RemotePortEnd", out result);
                return result;
            }
        }

        public System.UInt16? RemotePortStart
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("RemotePortStart", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemotePortStart", value);
            }
        }

        public System.String SettingName
        {
            get
            {
                System.String result;
                this.GetProperty("SettingName", out result);
                return result;
            }
        }
    }
}