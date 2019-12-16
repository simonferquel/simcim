using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMBasedOn : CIMDependency
    {
        protected CIMBasedOn()
        {
        }

        protected CIMBasedOn(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMStorageExtent Antecedent
        {
            get
            {
                CIMStorageExtent result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new CIMStorageExtent Dependent
        {
            get
            {
                CIMStorageExtent result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Dependent", value);
            }
        }

        public System.UInt64? EndingAddress
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EndingAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("EndingAddress", value);
            }
        }

        public System.UInt16? OrderIndex
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("OrderIndex", out result);
                return result;
            }

            set
            {
                this.SetProperty("OrderIndex", value);
            }
        }

        public System.UInt64? StartingAddress
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("StartingAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("StartingAddress", value);
            }
        }
    }
}