using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataAspnetstateASPNETStateService : Win32PerfRawData
    {
        public Win32PerfRawDataAspnetstateASPNETStateService()
        {
        }

        public Win32PerfRawDataAspnetstateASPNETStateService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? StateServerSessionsAbandoned
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StateServerSessionsAbandoned", out result);
                return result;
            }

            set
            {
                this.SetProperty("StateServerSessionsAbandoned", value);
            }
        }

        public System.UInt32? StateServerSessionsActive
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StateServerSessionsActive", out result);
                return result;
            }

            set
            {
                this.SetProperty("StateServerSessionsActive", value);
            }
        }

        public System.UInt32? StateServerSessionsTimedOut
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StateServerSessionsTimedOut", out result);
                return result;
            }

            set
            {
                this.SetProperty("StateServerSessionsTimedOut", value);
            }
        }

        public System.UInt32? StateServerSessionsTotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StateServerSessionsTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("StateServerSessionsTotal", value);
            }
        }
    }
}