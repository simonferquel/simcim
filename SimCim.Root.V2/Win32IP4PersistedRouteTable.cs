using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32IP4PersistedRouteTable : CIMLogicalElement
    {
        public Win32IP4PersistedRouteTable()
        {
        }

        public Win32IP4PersistedRouteTable(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.Int32 Metric1
        {
            get
            {
                System.Int32 result;
                this.GetProperty("Metric1", out result);
                return result;
            }

            set
            {
                this.SetProperty("Metric1", value);
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

        public Win32IP4RouteTable ResolveWin32ActiveRouteSystemElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ActiveRoute", "Win32_IP4RouteTable", "SameElement", "SystemElement");
            return instances.Select(i => (Win32IP4RouteTable)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}