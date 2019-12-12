using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NTLogEventComputer : GenericInfrastructureObject
    {
        public Win32NTLogEventComputer()
        {
        }

        public Win32NTLogEventComputer(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32ComputerSystem Computer
        {
            get
            {
                Win32ComputerSystem result;
                this.GetInfrastructureObjectProperty("Computer", out result);
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