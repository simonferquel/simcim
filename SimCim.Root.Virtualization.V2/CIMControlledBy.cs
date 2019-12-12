using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMControlledBy : CIMDeviceConnection
    {
        protected CIMControlledBy()
        {
        }

        protected CIMControlledBy(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMController Antecedent
        {
            get
            {
                CIMController result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public System.UInt16? AccessMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AccessMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("AccessMode", value);
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

        public System.UInt32? NumberOfHardResets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfHardResets", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfHardResets", value);
            }
        }

        public System.UInt32? NumberOfSoftResets
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfSoftResets", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfSoftResets", value);
            }
        }

        public System.DateTime? TimeOfDeviceReset
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeOfDeviceReset", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimeOfDeviceReset", value);
            }
        }
    }
}