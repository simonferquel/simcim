using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMController : CIMLogicalDevice
    {
        protected CIMController()
        {
        }

        protected CIMController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? MaxNumberControlled
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxNumberControlled", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxNumberControlled", value);
            }
        }

        public System.String ProtocolDescription
        {
            get
            {
                System.String result;
                this.GetProperty("ProtocolDescription", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProtocolDescription", value);
            }
        }

        public System.UInt16? ProtocolSupported
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ProtocolSupported", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProtocolSupported", value);
            }
        }

        public System.DateTime? TimeOfLastReset
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeOfLastReset", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimeOfLastReset", value);
            }
        }

        public CIMLogicalDevice ResolveCIMControlledByDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ControlledBy", "CIM_LogicalDevice", "Antecedent", "Dependent");
            return instances.Select(i => (CIMLogicalDevice)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMLogicalDevice ResolveMsvmControlledByDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ControlledBy", "CIM_LogicalDevice", "Antecedent", "Dependent");
            return instances.Select(i => (CIMLogicalDevice)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}