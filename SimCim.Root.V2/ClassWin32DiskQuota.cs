using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DiskQuota : GenericInfrastructureObject
    {
        public Win32DiskQuota()
        {
        }

        public Win32DiskQuota(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public Win32LogicalDisk QuotaVolume
        {
            get
            {
                Win32LogicalDisk result;
                this.GetInfrastructureObjectProperty("QuotaVolume", out result);
                return result;
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

        public Win32Account User
        {
            get
            {
                Win32Account result;
                this.GetInfrastructureObjectProperty("User", out result);
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