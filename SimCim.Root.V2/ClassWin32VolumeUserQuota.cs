using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32VolumeUserQuota : GenericInfrastructureObject
    {
        public Win32VolumeUserQuota()
        {
        }

        public Win32VolumeUserQuota(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32Account Account
        {
            get
            {
                Win32Account result;
                this.GetInfrastructureObjectProperty("Account", out result);
                return result;
            }
        }

        public System.UInt64? DiskSpaceUsed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DiskSpaceUsed", out result);
                return result;
            }
        }

        public System.UInt64? Limit
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Limit", out result);
                return result;
            }

            set
            {
                this.SetProperty("Limit", value);
            }
        }

        public System.UInt32? Status
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Status", out result);
                return result;
            }
        }

        public Win32Volume Volume
        {
            get
            {
                Win32Volume result;
                this.GetInfrastructureObjectProperty("Volume", out result);
                return result;
            }
        }

        public System.UInt64? WarningLimit
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WarningLimit", out result);
                return result;
            }

            set
            {
                this.SetProperty("WarningLimit", value);
            }
        }
    }
}