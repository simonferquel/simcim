using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ServerSession : CIMLogicalElement
    {
        public Win32ServerSession()
        {
        }

        public Win32ServerSession(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActiveTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveTime", value);
            }
        }

        public System.String ClientType
        {
            get
            {
                System.String result;
                this.GetProperty("ClientType", out result);
                return result;
            }

            set
            {
                this.SetProperty("ClientType", value);
            }
        }

        public System.String ComputerName
        {
            get
            {
                System.String result;
                this.GetProperty("ComputerName", out result);
                return result;
            }
        }

        public System.UInt32? IdleTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IdleTime", out result);
                return result;
            }
        }

        public System.UInt32? ResourcesOpened
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ResourcesOpened", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResourcesOpened", value);
            }
        }

        public System.UInt32? SessionType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SessionType", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionType", value);
            }
        }

        public System.String TransportName
        {
            get
            {
                System.String result;
                this.GetProperty("TransportName", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransportName", value);
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

            set
            {
                this.SetProperty("UserName", value);
            }
        }

        public Win32ServerConnection ResolveWin32SessionConnectionDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SessionConnection", "Win32_ServerConnection", "Antecedent", "Dependent");
            return instances.Select(i => (Win32ServerConnection)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}