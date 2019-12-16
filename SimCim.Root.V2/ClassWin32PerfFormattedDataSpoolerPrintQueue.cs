using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataSpoolerPrintQueue : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataSpoolerPrintQueue()
        {
        }

        public Win32PerfFormattedDataSpoolerPrintQueue(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AddNetworkPrinterCalls
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AddNetworkPrinterCalls", out result);
                return result;
            }

            set
            {
                this.SetProperty("AddNetworkPrinterCalls", value);
            }
        }

        public System.UInt64? BytesPrintedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesPrintedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesPrintedPersec", value);
            }
        }

        public System.UInt32? EnumerateNetworkPrinterCalls
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EnumerateNetworkPrinterCalls", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnumerateNetworkPrinterCalls", value);
            }
        }

        public System.UInt32? JobErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("JobErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("JobErrors", value);
            }
        }

        public System.UInt32? Jobs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Jobs", out result);
                return result;
            }

            set
            {
                this.SetProperty("Jobs", value);
            }
        }

        public System.UInt32? JobsSpooling
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("JobsSpooling", out result);
                return result;
            }

            set
            {
                this.SetProperty("JobsSpooling", value);
            }
        }

        public System.UInt32? MaxJobsSpooling
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxJobsSpooling", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxJobsSpooling", value);
            }
        }

        public System.UInt32? MaxReferences
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxReferences", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxReferences", value);
            }
        }

        public System.UInt32? NotReadyErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NotReadyErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("NotReadyErrors", value);
            }
        }

        public System.UInt32? OutofPaperErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutofPaperErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutofPaperErrors", value);
            }
        }

        public System.UInt32? References
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("References", out result);
                return result;
            }

            set
            {
                this.SetProperty("References", value);
            }
        }

        public System.UInt32? TotalJobsPrinted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalJobsPrinted", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalJobsPrinted", value);
            }
        }

        public System.UInt32? TotalPagesPrinted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalPagesPrinted", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalPagesPrinted", value);
            }
        }
    }
}