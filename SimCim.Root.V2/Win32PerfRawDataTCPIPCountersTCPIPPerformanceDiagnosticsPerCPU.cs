using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataTCPIPCountersTCPIPPerformanceDiagnosticsPerCPU : Win32PerfRawData
    {
        public Win32PerfRawDataTCPIPCountersTCPIPPerformanceDiagnosticsPerCPU()
        {
        }

        public Win32PerfRawDataTCPIPCountersTCPIPPerformanceDiagnosticsPerCPU(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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