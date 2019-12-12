using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataPerfOSNUMANodeMemory : Win32PerfRawData
    {
        public Win32PerfRawDataPerfOSNUMANodeMemory()
        {
        }

        public Win32PerfRawDataPerfOSNUMANodeMemory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AvailableMBytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvailableMBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvailableMBytes", value);
            }
        }

        public System.UInt32? FreeAndZeroPageListMBytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FreeAndZeroPageListMBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("FreeAndZeroPageListMBytes", value);
            }
        }

        public System.UInt32? StandbyListMBytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StandbyListMBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("StandbyListMBytes", value);
            }
        }

        public System.UInt32? TotalMBytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalMBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalMBytes", value);
            }
        }
    }
}