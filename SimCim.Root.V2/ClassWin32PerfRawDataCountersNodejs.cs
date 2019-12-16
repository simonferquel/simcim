using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersNodejs : Win32PerfRawData
    {
        public Win32PerfRawDataCountersNodejs()
        {
        }

        public Win32PerfRawDataCountersNodejs(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Activeserverconnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Activeserverconnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("Activeserverconnections", value);
            }
        }

        public System.UInt32? HTTPclientrequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HTTPclientrequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("HTTPclientrequests", value);
            }
        }

        public System.UInt32? HTTPclientresponses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HTTPclientresponses", out result);
                return result;
            }

            set
            {
                this.SetProperty("HTTPclientresponses", value);
            }
        }

        public System.UInt32? HTTPserverrequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HTTPserverrequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("HTTPserverrequests", value);
            }
        }

        public System.UInt32? HTTPserverresponses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HTTPserverresponses", out result);
                return result;
            }

            set
            {
                this.SetProperty("HTTPserverresponses", value);
            }
        }

        public System.UInt64? Networkbytesreceived
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Networkbytesreceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("Networkbytesreceived", value);
            }
        }

        public System.UInt64? Networkbytessent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Networkbytessent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Networkbytessent", value);
            }
        }

        public System.UInt32? PercentTimeinGC
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentTimeinGC", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentTimeinGC", value);
            }
        }

        public System.UInt64? Pipebytesreceived
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Pipebytesreceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("Pipebytesreceived", value);
            }
        }

        public System.UInt64? Pipebytessent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Pipebytessent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Pipebytessent", value);
            }
        }
    }
}