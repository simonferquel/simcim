using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetConnectionProfile : MSFTNetSettingData
    {
        public MSFTNetConnectionProfile()
        {
        }

        public MSFTNetConnectionProfile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.UInt32? IPv4Connectivity
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv4Connectivity", out result);
                return result;
            }
        }

        public System.UInt32? IPv6Connectivity
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv6Connectivity", out result);
                return result;
            }
        }

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
                return result;
            }
        }

        public System.UInt32? NetworkCategory
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NetworkCategory", out result);
                return result;
            }

            set
            {
                this.SetProperty("NetworkCategory", value);
            }
        }
    }
}