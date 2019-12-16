using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataNvspSwitchProcStatsHyperVVirtualSwitchProcessor : Win32PerfRawData
    {
        public Win32PerfRawDataNvspSwitchProcStatsHyperVVirtualSwitchProcessor()
        {
        }

        public Win32PerfRawDataNvspSwitchProcStatsHyperVVirtualSwitchProcessor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? NumberofTransmitCompletesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NumberofTransmitCompletesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofTransmitCompletesPersec", value);
            }
        }

        public System.UInt64? NumberofVMQs
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NumberofVMQs", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofVMQs", value);
            }
        }

        public System.UInt64? PacketsfromExternalPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsfromExternalPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsfromExternalPersec", value);
            }
        }

        public System.UInt64? PacketsfromInternalPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsfromInternalPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsfromInternalPersec", value);
            }
        }
    }
}