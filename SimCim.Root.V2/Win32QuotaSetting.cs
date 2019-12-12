using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32QuotaSetting : CIMSetting
    {
        public Win32QuotaSetting()
        {
        }

        public Win32QuotaSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Int64? DefaultLimit
        {
            get
            {
                System.Int64? result;
                this.GetProperty("DefaultLimit", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefaultLimit", value);
            }
        }

        public System.Int64? DefaultWarningLimit
        {
            get
            {
                System.Int64? result;
                this.GetProperty("DefaultWarningLimit", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefaultWarningLimit", value);
            }
        }

        public System.Boolean? ExceededNotification
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ExceededNotification", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExceededNotification", value);
            }
        }

        public System.UInt32? State
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("State", out result);
                return result;
            }

            set
            {
                this.SetProperty("State", value);
            }
        }

        public System.String VolumePath
        {
            get
            {
                System.String result;
                this.GetProperty("VolumePath", out result);
                return result;
            }

            set
            {
                this.SetProperty("VolumePath", value);
            }
        }

        public System.Boolean? WarningExceededNotification
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("WarningExceededNotification", out result);
                return result;
            }

            set
            {
                this.SetProperty("WarningExceededNotification", value);
            }
        }

        public Win32LogicalDisk ResolveWin32VolumeQuotaSettingElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_VolumeQuotaSetting", "Win32_LogicalDisk", "Setting", "Element");
            return instances.Select(i => (Win32LogicalDisk)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32Volume ResolveWin32VolumeQuotaElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_VolumeQuota", "Win32_Volume", "Setting", "Element");
            return instances.Select(i => (Win32Volume)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}