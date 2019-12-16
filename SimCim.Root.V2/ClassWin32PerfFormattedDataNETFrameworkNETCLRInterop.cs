using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataNETFrameworkNETCLRInterop : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataNETFrameworkNETCLRInterop()
        {
        }

        public Win32PerfFormattedDataNETFrameworkNETCLRInterop(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? NumberofCCWs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofCCWs", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofCCWs", value);
            }
        }

        public System.UInt32? Numberofmarshalling
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Numberofmarshalling", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofmarshalling", value);
            }
        }

        public System.UInt32? NumberofStubs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofStubs", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofStubs", value);
            }
        }

        public System.UInt32? NumberofTLBexportsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofTLBexportsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofTLBexportsPersec", value);
            }
        }

        public System.UInt32? NumberofTLBimportsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofTLBimportsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofTLBimportsPersec", value);
            }
        }
    }
}