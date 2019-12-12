using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SCSIController : CIMSCSIController
    {
        public Win32SCSIController()
        {
        }

        public Win32SCSIController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DeviceMap
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceMap", out result);
                return result;
            }
        }

        public System.String DriverName
        {
            get
            {
                System.String result;
                this.GetProperty("DriverName", out result);
                return result;
            }
        }

        public System.String HardwareVersion
        {
            get
            {
                System.String result;
                this.GetProperty("HardwareVersion", out result);
                return result;
            }
        }

        public System.UInt32? Index
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Index", out result);
                return result;
            }
        }

        public System.String Manufacturer
        {
            get
            {
                System.String result;
                this.GetProperty("Manufacturer", out result);
                return result;
            }
        }

        public CIMLogicalDevice ResolveWin32SCSIControllerDeviceDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SCSIControllerDevice", "CIM_LogicalDevice", "Antecedent", "Dependent");
            return instances.Select(i => (CIMLogicalDevice)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}