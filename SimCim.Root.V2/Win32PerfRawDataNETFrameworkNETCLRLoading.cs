using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataNETFrameworkNETCLRLoading : Win32PerfRawData
    {
        public Win32PerfRawDataNETFrameworkNETCLRLoading()
        {
        }

        public Win32PerfRawDataNETFrameworkNETCLRLoading(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AssemblySearchLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AssemblySearchLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("AssemblySearchLength", value);
            }
        }

        public System.UInt64? BytesinLoaderHeap
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesinLoaderHeap", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesinLoaderHeap", value);
            }
        }

        public System.UInt32? Currentappdomains
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Currentappdomains", out result);
                return result;
            }

            set
            {
                this.SetProperty("Currentappdomains", value);
            }
        }

        public System.UInt32? CurrentAssemblies
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentAssemblies", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentAssemblies", value);
            }
        }

        public System.UInt32? CurrentClassesLoaded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentClassesLoaded", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentClassesLoaded", value);
            }
        }

        public System.UInt64? PercentTimeLoading
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentTimeLoading", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentTimeLoading", value);
            }
        }

        public System.UInt32? Rateofappdomains
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Rateofappdomains", out result);
                return result;
            }

            set
            {
                this.SetProperty("Rateofappdomains", value);
            }
        }

        public System.UInt32? Rateofappdomainsunloaded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Rateofappdomainsunloaded", out result);
                return result;
            }

            set
            {
                this.SetProperty("Rateofappdomainsunloaded", value);
            }
        }

        public System.UInt32? RateofAssemblies
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RateofAssemblies", out result);
                return result;
            }

            set
            {
                this.SetProperty("RateofAssemblies", value);
            }
        }

        public System.UInt32? RateofClassesLoaded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RateofClassesLoaded", out result);
                return result;
            }

            set
            {
                this.SetProperty("RateofClassesLoaded", value);
            }
        }

        public System.UInt32? RateofLoadFailures
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RateofLoadFailures", out result);
                return result;
            }

            set
            {
                this.SetProperty("RateofLoadFailures", value);
            }
        }

        public System.UInt32? TotalAppdomains
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalAppdomains", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalAppdomains", value);
            }
        }

        public System.UInt32? Totalappdomainsunloaded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Totalappdomainsunloaded", out result);
                return result;
            }

            set
            {
                this.SetProperty("Totalappdomainsunloaded", value);
            }
        }

        public System.UInt32? TotalAssemblies
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalAssemblies", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalAssemblies", value);
            }
        }

        public System.UInt32? TotalClassesLoaded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalClassesLoaded", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalClassesLoaded", value);
            }
        }

        public System.UInt32? TotalNumberofLoadFailures
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalNumberofLoadFailures", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalNumberofLoadFailures", value);
            }
        }
    }
}