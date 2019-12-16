using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSecuritySettingData : CIMSettingData
    {
        public MsvmSecuritySettingData()
        {
        }

        public MsvmSecuritySettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AppContainerLaunchOptOut
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AppContainerLaunchOptOut", out result);
                return result;
            }
        }

        public System.Boolean? BindToHostTpm
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("BindToHostTpm", out result);
                return result;
            }
        }

        public System.Boolean? DataProtectionRequested
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DataProtectionRequested", out result);
                return result;
            }
        }

        public System.Boolean? EncryptStateAndVmMigrationTraffic
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EncryptStateAndVmMigrationTraffic", out result);
                return result;
            }
        }

        public System.Boolean? KsdEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("KsdEnabled", out result);
                return result;
            }
        }

        public System.Boolean? ShieldingRequested
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ShieldingRequested", out result);
                return result;
            }
        }

        public System.Boolean? TpmEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("TpmEnabled", out result);
                return result;
            }
        }

        public System.Boolean? VirtualizationBasedSecurityOptOut
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("VirtualizationBasedSecurityOptOut", out result);
                return result;
            }
        }
    }
}