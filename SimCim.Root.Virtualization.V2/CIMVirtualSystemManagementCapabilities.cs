using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMVirtualSystemManagementCapabilities : CIMEnabledLogicalElementCapabilities
    {
        protected CIMVirtualSystemManagementCapabilities()
        {
        }

        protected CIMVirtualSystemManagementCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] AsynchronousMethodsSupported
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("AsynchronousMethodsSupported", out result);
                return result;
            }

            set
            {
                this.SetProperty("AsynchronousMethodsSupported", value);
            }
        }

        public System.UInt16[] IndicationsSupported
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("IndicationsSupported", out result);
                return result;
            }

            set
            {
                this.SetProperty("IndicationsSupported", value);
            }
        }

        public System.UInt16[] SynchronousMethodsSupported
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("SynchronousMethodsSupported", out result);
                return result;
            }

            set
            {
                this.SetProperty("SynchronousMethodsSupported", value);
            }
        }

        public System.String[] VirtualSystemTypesSupported
        {
            get
            {
                System.String[] result;
                this.GetProperty("VirtualSystemTypesSupported", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualSystemTypesSupported", value);
            }
        }
    }
}