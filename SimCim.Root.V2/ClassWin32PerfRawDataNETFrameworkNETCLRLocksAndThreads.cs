using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataNETFrameworkNETCLRLocksAndThreads : Win32PerfRawData
    {
        public Win32PerfRawDataNETFrameworkNETCLRLocksAndThreads()
        {
        }

        public Win32PerfRawDataNETFrameworkNETCLRLocksAndThreads(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ContentionRatePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ContentionRatePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ContentionRatePersec", value);
            }
        }

        public System.UInt32? CurrentQueueLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentQueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentQueueLength", value);
            }
        }

        public System.UInt32? NumberofcurrentlogicalThreads
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofcurrentlogicalThreads", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofcurrentlogicalThreads", value);
            }
        }

        public System.UInt32? NumberofcurrentphysicalThreads
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofcurrentphysicalThreads", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofcurrentphysicalThreads", value);
            }
        }

        public System.UInt32? Numberofcurrentrecognizedthreads
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Numberofcurrentrecognizedthreads", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofcurrentrecognizedthreads", value);
            }
        }

        public System.UInt32? Numberoftotalrecognizedthreads
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Numberoftotalrecognizedthreads", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberoftotalrecognizedthreads", value);
            }
        }

        public System.UInt32? QueueLengthPeak
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QueueLengthPeak", out result);
                return result;
            }

            set
            {
                this.SetProperty("QueueLengthPeak", value);
            }
        }

        public System.UInt32? QueueLengthPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QueueLengthPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("QueueLengthPersec", value);
            }
        }

        public System.UInt32? RateofrecognizedthreadsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("rateofrecognizedthreadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("rateofrecognizedthreadsPersec", value);
            }
        }

        public System.UInt32? TotalNumberofContentions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalNumberofContentions", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalNumberofContentions", value);
            }
        }
    }
}