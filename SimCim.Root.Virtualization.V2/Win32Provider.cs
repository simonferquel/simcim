using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class Win32Provider : Provider
    {
        public Win32Provider()
        {
        }

        public Win32Provider(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ClientLoadableCLSID
        {
            get
            {
                System.String result;
                this.GetProperty("ClientLoadableCLSID", out result);
                return result;
            }

            set
            {
                this.SetProperty("ClientLoadableCLSID", value);
            }
        }

        public System.String CLSID
        {
            get
            {
                System.String result;
                this.GetProperty("CLSID", out result);
                return result;
            }

            set
            {
                this.SetProperty("CLSID", value);
            }
        }

        public System.Int32? Concurrency
        {
            get
            {
                System.Int32? result;
                this.GetProperty("Concurrency", out result);
                return result;
            }

            set
            {
                this.SetProperty("Concurrency", value);
            }
        }

        public System.String DefaultMachineName
        {
            get
            {
                System.String result;
                this.GetProperty("DefaultMachineName", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefaultMachineName", value);
            }
        }

        public System.Boolean? Enabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Enabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("Enabled", value);
            }
        }

        public System.String HostingModel
        {
            get
            {
                System.String result;
                this.GetProperty("HostingModel", out result);
                return result;
            }

            set
            {
                this.SetProperty("HostingModel", value);
            }
        }

        public System.Int32? ImpersonationLevel
        {
            get
            {
                System.Int32? result;
                this.GetProperty("ImpersonationLevel", out result);
                return result;
            }

            set
            {
                this.SetProperty("ImpersonationLevel", value);
            }
        }

        public System.Int32? InitializationReentrancy
        {
            get
            {
                System.Int32? result;
                this.GetProperty("InitializationReentrancy", out result);
                return result;
            }

            set
            {
                this.SetProperty("InitializationReentrancy", value);
            }
        }

        public System.DateTime? InitializationTimeoutInterval
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("InitializationTimeoutInterval", out result);
                return result;
            }

            set
            {
                this.SetProperty("InitializationTimeoutInterval", value);
            }
        }

        public System.Boolean? InitializeAsAdminFirst
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("InitializeAsAdminFirst", out result);
                return result;
            }

            set
            {
                this.SetProperty("InitializeAsAdminFirst", value);
            }
        }

        public System.DateTime? OperationTimeoutInterval
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("OperationTimeoutInterval", out result);
                return result;
            }

            set
            {
                this.SetProperty("OperationTimeoutInterval", value);
            }
        }

        public System.Boolean? PerLocaleInitialization
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PerLocaleInitialization", out result);
                return result;
            }

            set
            {
                this.SetProperty("PerLocaleInitialization", value);
            }
        }

        public System.Boolean? PerUserInitialization
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PerUserInitialization", out result);
                return result;
            }

            set
            {
                this.SetProperty("PerUserInitialization", value);
            }
        }

        public System.Boolean? Pure
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Pure", out result);
                return result;
            }

            set
            {
                this.SetProperty("Pure", value);
            }
        }

        public System.String SecurityDescriptor
        {
            get
            {
                System.String result;
                this.GetProperty("SecurityDescriptor", out result);
                return result;
            }

            set
            {
                this.SetProperty("SecurityDescriptor", value);
            }
        }

        public System.Boolean? SupportsExplicitShutdown
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsExplicitShutdown", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportsExplicitShutdown", value);
            }
        }

        public System.Boolean? SupportsExtendedStatus
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsExtendedStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportsExtendedStatus", value);
            }
        }

        public System.Boolean? SupportsQuotas
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsQuotas", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportsQuotas", value);
            }
        }

        public System.Boolean? SupportsSendStatus
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsSendStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportsSendStatus", value);
            }
        }

        public System.Boolean? SupportsShutdown
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsShutdown", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportsShutdown", value);
            }
        }

        public System.Boolean? SupportsThrottling
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsThrottling", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportsThrottling", value);
            }
        }

        public System.DateTime? UnloadTimeout
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("UnloadTimeout", out result);
                return result;
            }

            set
            {
                this.SetProperty("UnloadTimeout", value);
            }
        }

        public System.UInt32? Version
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Version", out result);
                return result;
            }

            set
            {
                this.SetProperty("Version", value);
            }
        }
    }
}