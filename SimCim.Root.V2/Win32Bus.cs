﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Bus : CIMLogicalDevice
    {
        public Win32Bus()
        {
        }

        public Win32Bus(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BusNum
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BusNum", out result);
                return result;
            }
        }

        public System.UInt32? BusType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BusType", out result);
                return result;
            }
        }

        public CIMLogicalDevice ResolveWin32DeviceBusDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_DeviceBus", "CIM_LogicalDevice", "Antecedent", "Dependent");
            return instances.Select(i => (CIMLogicalDevice)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}