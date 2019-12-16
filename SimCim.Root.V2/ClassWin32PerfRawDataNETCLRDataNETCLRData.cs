using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataNETCLRDataNETCLRData : Win32PerfRawData
    {
        public Win32PerfRawDataNETCLRDataNETCLRData()
        {
        }

        public Win32PerfRawDataNETCLRDataNETCLRData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? SqlClientCurrentNumberconnectionpools
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SqlClientCurrentNumberconnectionpools", out result);
                return result;
            }

            set
            {
                this.SetProperty("SqlClientCurrentNumberconnectionpools", value);
            }
        }

        public System.UInt32? SqlClientCurrentNumberpooledandnonpooledconnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SqlClientCurrentNumberpooledandnonpooledconnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("SqlClientCurrentNumberpooledandnonpooledconnections", value);
            }
        }

        public System.UInt32? SqlClientCurrentNumberpooledconnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SqlClientCurrentNumberpooledconnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("SqlClientCurrentNumberpooledconnections", value);
            }
        }

        public System.UInt32? SqlClientPeakNumberpooledconnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SqlClientPeakNumberpooledconnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("SqlClientPeakNumberpooledconnections", value);
            }
        }

        public System.UInt32? SqlClientTotalNumberfailedcommands
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SqlClientTotalNumberfailedcommands", out result);
                return result;
            }

            set
            {
                this.SetProperty("SqlClientTotalNumberfailedcommands", value);
            }
        }

        public System.UInt32? SqlClientTotalNumberfailedconnects
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SqlClientTotalNumberfailedconnects", out result);
                return result;
            }

            set
            {
                this.SetProperty("SqlClientTotalNumberfailedconnects", value);
            }
        }
    }
}