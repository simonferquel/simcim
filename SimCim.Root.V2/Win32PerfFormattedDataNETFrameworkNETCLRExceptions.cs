using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataNETFrameworkNETCLRExceptions : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataNETFrameworkNETCLRExceptions()
        {
        }

        public Win32PerfFormattedDataNETFrameworkNETCLRExceptions(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? NumberofExcepsThrown
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofExcepsThrown", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofExcepsThrown", value);
            }
        }

        public System.UInt32? NumberofExcepsThrownPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofExcepsThrownPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofExcepsThrownPersec", value);
            }
        }

        public System.UInt32? NumberofFiltersPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofFiltersPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofFiltersPersec", value);
            }
        }

        public System.UInt32? NumberofFinallysPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofFinallysPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofFinallysPersec", value);
            }
        }

        public System.UInt32? ThrowToCatchDepthPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ThrowToCatchDepthPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ThrowToCatchDepthPersec", value);
            }
        }
    }
}