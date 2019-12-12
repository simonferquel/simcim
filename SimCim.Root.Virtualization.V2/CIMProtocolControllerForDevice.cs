using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMProtocolControllerForDevice : CIMDependency
    {
        protected CIMProtocolControllerForDevice()
        {
        }

        protected CIMProtocolControllerForDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMProtocolController Antecedent
        {
            get
            {
                CIMProtocolController result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new CIMLogicalDevice Dependent
        {
            get
            {
                CIMLogicalDevice result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Dependent", value);
            }
        }

        public System.UInt16? AccessPriority
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AccessPriority", out result);
                return result;
            }

            set
            {
                this.SetProperty("AccessPriority", value);
            }
        }

        public System.UInt16? AccessState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AccessState", out result);
                return result;
            }

            set
            {
                this.SetProperty("AccessState", value);
            }
        }

        public System.String DeviceNumber
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeviceNumber", value);
            }
        }
    }
}