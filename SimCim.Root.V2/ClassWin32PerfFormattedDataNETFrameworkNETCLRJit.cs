using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataNETFrameworkNETCLRJit : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataNETFrameworkNETCLRJit()
        {
        }

        public Win32PerfFormattedDataNETFrameworkNETCLRJit(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ILBytesJittedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ILBytesJittedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ILBytesJittedPersec", value);
            }
        }

        public System.UInt32? NumberofILBytesJitted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofILBytesJitted", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofILBytesJitted", value);
            }
        }

        public System.UInt32? NumberofMethodsJitted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofMethodsJitted", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofMethodsJitted", value);
            }
        }

        public System.UInt32? PercentTimeinJit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentTimeinJit", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentTimeinJit", value);
            }
        }

        public System.UInt32? StandardJitFailures
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StandardJitFailures", out result);
                return result;
            }

            set
            {
                this.SetProperty("StandardJitFailures", value);
            }
        }

        public System.UInt32? TotalNumberofILBytesJitted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalNumberofILBytesJitted", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalNumberofILBytesJitted", value);
            }
        }
    }
}