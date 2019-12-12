using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMDeviceConnection : CIMDependency
    {
        protected CIMDeviceConnection()
        {
        }

        protected CIMDeviceConnection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMLogicalDevice Antecedent
        {
            get
            {
                CIMLogicalDevice result;
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

        public System.UInt32? NegotiatedDataWidth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NegotiatedDataWidth", out result);
                return result;
            }

            set
            {
                this.SetProperty("NegotiatedDataWidth", value);
            }
        }

        public System.UInt64? NegotiatedSpeed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NegotiatedSpeed", out result);
                return result;
            }

            set
            {
                this.SetProperty("NegotiatedSpeed", value);
            }
        }
    }
}