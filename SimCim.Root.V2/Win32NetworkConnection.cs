using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NetworkConnection : CIMLogicalElement
    {
        public Win32NetworkConnection()
        {
        }

        public Win32NetworkConnection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AccessMask
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AccessMask", out result);
                return result;
            }
        }

        public System.String Comment
        {
            get
            {
                System.String result;
                this.GetProperty("Comment", out result);
                return result;
            }
        }

        public System.String ConnectionState
        {
            get
            {
                System.String result;
                this.GetProperty("ConnectionState", out result);
                return result;
            }
        }

        public System.String ConnectionType
        {
            get
            {
                System.String result;
                this.GetProperty("ConnectionType", out result);
                return result;
            }
        }

        public System.String DisplayType
        {
            get
            {
                System.String result;
                this.GetProperty("DisplayType", out result);
                return result;
            }
        }

        public System.String LocalName
        {
            get
            {
                System.String result;
                this.GetProperty("LocalName", out result);
                return result;
            }
        }

        public System.Boolean? Persistent
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Persistent", out result);
                return result;
            }
        }

        public System.String ProviderName
        {
            get
            {
                System.String result;
                this.GetProperty("ProviderName", out result);
                return result;
            }
        }

        public System.String RemoteName
        {
            get
            {
                System.String result;
                this.GetProperty("RemoteName", out result);
                return result;
            }
        }

        public System.String RemotePath
        {
            get
            {
                System.String result;
                this.GetProperty("RemotePath", out result);
                return result;
            }
        }

        public System.String ResourceType
        {
            get
            {
                System.String result;
                this.GetProperty("ResourceType", out result);
                return result;
            }
        }

        public System.String UserName
        {
            get
            {
                System.String result;
                this.GetProperty("UserName", out result);
                return result;
            }
        }

        public IEnumerable<Win32ComputerSystem> ResolveWin32SystemNetworkConnectionsGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemNetworkConnections", "Win32_ComputerSystem", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32ComputerSystem)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}