using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualSystemManagementServiceSettingData : CIMSettingData
    {
        public MsvmVirtualSystemManagementServiceSettingData()
        {
        }

        public MsvmVirtualSystemManagementServiceSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String BiosLockString
        {
            get
            {
                System.String result;
                this.GetProperty("BiosLockString", out result);
                return result;
            }
        }

        public System.String CurrentWWNNAddress
        {
            get
            {
                System.String result;
                this.GetProperty("CurrentWWNNAddress", out result);
                return result;
            }
        }

        public System.String DefaultExternalDataRoot
        {
            get
            {
                System.String result;
                this.GetProperty("DefaultExternalDataRoot", out result);
                return result;
            }
        }

        public System.UInt16? DefaultVirtualHardDiskCachingMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DefaultVirtualHardDiskCachingMode", out result);
                return result;
            }
        }

        public System.String DefaultVirtualHardDiskPath
        {
            get
            {
                System.String result;
                this.GetProperty("DefaultVirtualHardDiskPath", out result);
                return result;
            }
        }

        public System.Boolean? EnhancedSessionModeEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnhancedSessionModeEnabled", out result);
                return result;
            }
        }

        public System.UInt32? HbaLunTimeout
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HbaLunTimeout", out result);
                return result;
            }
        }

        public System.Boolean? HypervisorRootSchedulerEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HypervisorRootSchedulerEnabled", out result);
                return result;
            }
        }

        public System.String MaximumMacAddress
        {
            get
            {
                System.String result;
                this.GetProperty("MaximumMacAddress", out result);
                return result;
            }
        }

        public System.String MaximumWWPNAddress
        {
            get
            {
                System.String result;
                this.GetProperty("MaximumWWPNAddress", out result);
                return result;
            }
        }

        public System.String MinimumMacAddress
        {
            get
            {
                System.String result;
                this.GetProperty("MinimumMacAddress", out result);
                return result;
            }
        }

        public System.String MinimumWWPNAddress
        {
            get
            {
                System.String result;
                this.GetProperty("MinimumWWPNAddress", out result);
                return result;
            }
        }

        public System.Boolean? NumaSpanningEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NumaSpanningEnabled", out result);
                return result;
            }
        }

        public System.String PrimaryOwnerContact
        {
            get
            {
                System.String result;
                this.GetProperty("PrimaryOwnerContact", out result);
                return result;
            }
        }

        public System.String PrimaryOwnerName
        {
            get
            {
                System.String result;
                this.GetProperty("PrimaryOwnerName", out result);
                return result;
            }
        }
    }
}