using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMLogicalPort : CIMLogicalDevice
    {
        protected CIMLogicalPort()
        {
        }

        protected CIMLogicalPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? MaxSpeed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxSpeed", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxSpeed", value);
            }
        }

        public System.String OtherPortType
        {
            get
            {
                System.String result;
                this.GetProperty("OtherPortType", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherPortType", value);
            }
        }

        public System.UInt16? PortType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PortType", out result);
                return result;
            }

            set
            {
                this.SetProperty("PortType", value);
            }
        }

        public System.UInt64? RequestedSpeed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RequestedSpeed", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestedSpeed", value);
            }
        }

        public System.UInt64? Speed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Speed", out result);
                return result;
            }

            set
            {
                this.SetProperty("Speed", value);
            }
        }

        public System.UInt16? UsageRestriction
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("UsageRestriction", out result);
                return result;
            }

            set
            {
                this.SetProperty("UsageRestriction", value);
            }
        }

        public CIMLogicalDevice ResolveCIMPortOnDeviceAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_PortOnDevice", "CIM_LogicalDevice", "Dependent", "Antecedent");
            return instances.Select(i => (CIMLogicalDevice)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<CIMLogicalDevice> ResolveMsvmSerialPortOnSerialControllerAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SerialPortOnSerialController", "CIM_LogicalDevice", "Dependent", "Antecedent");
            return instances.Select(i => (CIMLogicalDevice)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}