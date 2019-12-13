using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32IP4RouteTable : CIMLogicalElement
    {
        public Win32IP4RouteTable()
        {
        }

        public Win32IP4RouteTable(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Age
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Age", out result);
                return result;
            }
        }

        public System.String Destination
        {
            get
            {
                System.String result;
                this.GetProperty("Destination", out result);
                return result;
            }

            set
            {
                this.SetProperty("Destination", value);
            }
        }

        public System.String Information
        {
            get
            {
                System.String result;
                this.GetProperty("Information", out result);
                return result;
            }
        }

        public System.Int32 InterfaceIndex
        {
            get
            {
                System.Int32 result;
                this.GetProperty("InterfaceIndex", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterfaceIndex", value);
            }
        }

        public System.String Mask
        {
            get
            {
                System.String result;
                this.GetProperty("Mask", out result);
                return result;
            }

            set
            {
                this.SetProperty("Mask", value);
            }
        }

        public System.Int32? Metric1
        {
            get
            {
                System.Int32? result;
                this.GetProperty("Metric1", out result);
                return result;
            }

            set
            {
                this.SetProperty("Metric1", value);
            }
        }

        public System.Int32? Metric2
        {
            get
            {
                System.Int32? result;
                this.GetProperty("Metric2", out result);
                return result;
            }

            set
            {
                this.SetProperty("Metric2", value);
            }
        }

        public System.Int32? Metric3
        {
            get
            {
                System.Int32? result;
                this.GetProperty("Metric3", out result);
                return result;
            }

            set
            {
                this.SetProperty("Metric3", value);
            }
        }

        public System.Int32? Metric4
        {
            get
            {
                System.Int32? result;
                this.GetProperty("Metric4", out result);
                return result;
            }

            set
            {
                this.SetProperty("Metric4", value);
            }
        }

        public System.Int32? Metric5
        {
            get
            {
                System.Int32? result;
                this.GetProperty("Metric5", out result);
                return result;
            }

            set
            {
                this.SetProperty("Metric5", value);
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

            set
            {
                this.SetProperty("NextHop", value);
            }
        }

        public System.UInt32? Protocol
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Protocol", out result);
                return result;
            }
        }

        public System.UInt32? Type
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Type", out result);
                return result;
            }

            set
            {
                this.SetProperty("Type", value);
            }
        }

        public Win32IP4PersistedRouteTable ResolveWin32ActiveRouteSameElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ActiveRoute", "Win32_IP4PersistedRouteTable", "SystemElement", "SameElement");
            return instances.Select(i => (Win32IP4PersistedRouteTable)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}