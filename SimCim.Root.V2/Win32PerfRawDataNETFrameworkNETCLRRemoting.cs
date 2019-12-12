using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataNETFrameworkNETCLRRemoting : Win32PerfRawData
    {
        public Win32PerfRawDataNETFrameworkNETCLRRemoting()
        {
        }

        public Win32PerfRawDataNETFrameworkNETCLRRemoting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Channels
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Channels", out result);
                return result;
            }

            set
            {
                this.SetProperty("Channels", value);
            }
        }

        public System.UInt32? ContextBoundClassesLoaded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ContextBoundClassesLoaded", out result);
                return result;
            }

            set
            {
                this.SetProperty("ContextBoundClassesLoaded", value);
            }
        }

        public System.UInt32? ContextBoundObjectsAllocPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ContextBoundObjectsAllocPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ContextBoundObjectsAllocPersec", value);
            }
        }

        public System.UInt32? ContextProxies
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ContextProxies", out result);
                return result;
            }

            set
            {
                this.SetProperty("ContextProxies", value);
            }
        }

        public System.UInt32? Contexts
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Contexts", out result);
                return result;
            }

            set
            {
                this.SetProperty("Contexts", value);
            }
        }

        public System.UInt32? RemoteCallsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RemoteCallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteCallsPersec", value);
            }
        }

        public System.UInt32? TotalRemoteCalls
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalRemoteCalls", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalRemoteCalls", value);
            }
        }
    }
}