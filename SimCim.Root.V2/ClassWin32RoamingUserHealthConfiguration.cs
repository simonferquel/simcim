using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32RoamingUserHealthConfiguration : GenericInfrastructureObject
    {
        public Win32RoamingUserHealthConfiguration()
        {
        }

        public Win32RoamingUserHealthConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? HealthStatusForTempProfiles
        {
            get
            {
                System.Byte? result;
                this.GetProperty("HealthStatusForTempProfiles", out result);
                return result;
            }

            set
            {
                this.SetProperty("HealthStatusForTempProfiles", value);
            }
        }

        public System.UInt16? LastProfileDownloadIntervalCautionInHours
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LastProfileDownloadIntervalCautionInHours", out result);
                return result;
            }

            set
            {
                this.SetProperty("LastProfileDownloadIntervalCautionInHours", value);
            }
        }

        public System.UInt16? LastProfileDownloadIntervalUnhealthyInHours
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LastProfileDownloadIntervalUnhealthyInHours", out result);
                return result;
            }

            set
            {
                this.SetProperty("LastProfileDownloadIntervalUnhealthyInHours", value);
            }
        }

        public System.UInt16? LastProfileUploadIntervalCautionInHours
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LastProfileUploadIntervalCautionInHours", out result);
                return result;
            }

            set
            {
                this.SetProperty("LastProfileUploadIntervalCautionInHours", value);
            }
        }

        public System.UInt16? LastProfileUploadIntervalUnhealthyInHours
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LastProfileUploadIntervalUnhealthyInHours", out result);
                return result;
            }

            set
            {
                this.SetProperty("LastProfileUploadIntervalUnhealthyInHours", value);
            }
        }
    }
}