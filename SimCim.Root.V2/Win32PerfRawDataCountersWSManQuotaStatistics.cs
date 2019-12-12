using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersWSManQuotaStatistics : Win32PerfRawData
    {
        public Win32PerfRawDataCountersWSManQuotaStatistics()
        {
        }

        public Win32PerfRawDataCountersWSManQuotaStatistics(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActiveOperations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveOperations", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveOperations", value);
            }
        }

        public System.UInt32? ActiveShells
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveShells", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveShells", value);
            }
        }

        public System.UInt32? ActiveUsers
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveUsers", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveUsers", value);
            }
        }

        public System.UInt32? ProcessID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessID", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProcessID", value);
            }
        }

        public System.UInt32? SystemQuotaViolationsPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SystemQuotaViolationsPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemQuotaViolationsPerSecond", value);
            }
        }

        public System.UInt32? TotalRequestsPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalRequestsPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalRequestsPerSecond", value);
            }
        }

        public System.UInt32? UserQuotaViolationsPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UserQuotaViolationsPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("UserQuotaViolationsPerSecond", value);
            }
        }
    }
}