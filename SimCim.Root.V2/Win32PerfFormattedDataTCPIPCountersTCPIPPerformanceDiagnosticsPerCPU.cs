using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnosticsPerCPU : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnosticsPerCPU()
        {
        }

        public Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnosticsPerCPU(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? TCPcurrentconnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TCPcurrentconnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPcurrentconnections", value);
            }
        }
    }
}