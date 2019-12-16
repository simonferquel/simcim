using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMFCPort : CIMNetworkPort
    {
        protected CIMFCPort()
        {
        }

        protected CIMFCPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] ActiveCOS
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("ActiveCOS", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveCOS", value);
            }
        }

        public System.UInt16[] ActiveFC4Types
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("ActiveFC4Types", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveFC4Types", value);
            }
        }

        public System.UInt16[] SupportedCOS
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("SupportedCOS", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportedCOS", value);
            }
        }

        public System.UInt16[] SupportedFC4Types
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("SupportedFC4Types", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportedFC4Types", value);
            }
        }
    }
}