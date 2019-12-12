using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataLocalSessionManagerTerminalServices : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataLocalSessionManagerTerminalServices()
        {
        }

        public Win32PerfFormattedDataLocalSessionManagerTerminalServices(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActiveSessions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveSessions", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveSessions", value);
            }
        }

        public System.UInt32? InactiveSessions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InactiveSessions", out result);
                return result;
            }

            set
            {
                this.SetProperty("InactiveSessions", value);
            }
        }

        public System.UInt32? TotalSessions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalSessions", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalSessions", value);
            }
        }
    }
}