using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersNetlogon : Win32PerfRawData
    {
        public Win32PerfRawDataCountersNetlogon()
        {
        }

        public Win32PerfRawDataCountersNetlogon(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AverageSemaphoreHoldTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AverageSemaphoreHoldTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageSemaphoreHoldTime", value);
            }
        }

        public System.UInt32? AverageSemaphoreHoldTimeBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AverageSemaphoreHoldTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageSemaphoreHoldTime_Base", value);
            }
        }

        public System.UInt32? LastAuthenticationTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LastAuthenticationTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("LastAuthenticationTime", value);
            }
        }

        public System.UInt32? LastAuthenticationTimeBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LastAuthenticationTime_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("LastAuthenticationTime_Base", value);
            }
        }

        public System.UInt64? SemaphoreAcquires
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SemaphoreAcquires", out result);
                return result;
            }

            set
            {
                this.SetProperty("SemaphoreAcquires", value);
            }
        }

        public System.UInt32? SemaphoreHolders
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SemaphoreHolders", out result);
                return result;
            }

            set
            {
                this.SetProperty("SemaphoreHolders", value);
            }
        }

        public System.UInt64? SemaphoreTimeouts
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SemaphoreTimeouts", out result);
                return result;
            }

            set
            {
                this.SetProperty("SemaphoreTimeouts", value);
            }
        }

        public System.UInt32? SemaphoreWaiters
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SemaphoreWaiters", out result);
                return result;
            }

            set
            {
                this.SetProperty("SemaphoreWaiters", value);
            }
        }
    }
}