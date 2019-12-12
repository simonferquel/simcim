using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMVirtualSystemMigrationCapabilities : CIMCapabilities
    {
        protected CIMVirtualSystemMigrationCapabilities()
        {
        }

        protected CIMVirtualSystemMigrationCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.UInt16[] DestinationHostFormatsSupported
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("DestinationHostFormatsSupported", out result);
                return result;
            }

            set
            {
                this.SetProperty("DestinationHostFormatsSupported", value);
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
    }
}