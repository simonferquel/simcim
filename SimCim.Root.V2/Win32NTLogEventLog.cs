using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NTLogEventLog : GenericInfrastructureObject
    {
        public Win32NTLogEventLog()
        {
        }

        public Win32NTLogEventLog(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32NTEventlogFile Log
        {
            get
            {
                Win32NTEventlogFile result;
                this.GetInfrastructureObjectProperty("Log", out result);
                return result;
            }
        }

        public Win32NTLogEvent Record
        {
            get
            {
                Win32NTLogEvent result;
                this.GetInfrastructureObjectProperty("Record", out result);
                return result;
            }
        }
    }
}