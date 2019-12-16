using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Processor : CIMProcessor
    {
        public Win32Processor()
        {
        }

        public Win32Processor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Architecture
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Architecture", out result);
                return result;
            }
        }

        public System.String AssetTag
        {
            get
            {
                System.String result;
                this.GetProperty("AssetTag", out result);
                return result;
            }
        }

        public System.UInt32? Characteristics
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Characteristics", out result);
                return result;
            }
        }

        public System.UInt16? CpuStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CpuStatus", out result);
                return result;
            }
        }

        public System.UInt16? CurrentVoltage
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CurrentVoltage", out result);
                return result;
            }
        }

        public System.UInt32? ExtClock
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExtClock", out result);
                return result;
            }
        }

        public System.UInt32? L2CacheSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L2CacheSize", out result);
                return result;
            }
        }

        public System.UInt32? L2CacheSpeed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L2CacheSpeed", out result);
                return result;
            }
        }

        public System.UInt32? L3CacheSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L3CacheSize", out result);
                return result;
            }
        }

        public System.UInt32? L3CacheSpeed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("L3CacheSpeed", out result);
                return result;
            }
        }

        public System.UInt16? Level
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Level", out result);
                return result;
            }
        }

        public System.String Manufacturer
        {
            get
            {
                System.String result;
                this.GetProperty("Manufacturer", out result);
                return result;
            }
        }

        public System.UInt32? NumberOfCores
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfCores", out result);
                return result;
            }
        }

        public System.UInt32? NumberOfEnabledCore
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfEnabledCore", out result);
                return result;
            }
        }

        public System.UInt32? NumberOfLogicalProcessors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfLogicalProcessors", out result);
                return result;
            }
        }

        public System.String PartNumber
        {
            get
            {
                System.String result;
                this.GetProperty("PartNumber", out result);
                return result;
            }
        }

        public System.String ProcessorId
        {
            get
            {
                System.String result;
                this.GetProperty("ProcessorId", out result);
                return result;
            }
        }

        public System.UInt16? ProcessorType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ProcessorType", out result);
                return result;
            }
        }

        public System.UInt16? Revision
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Revision", out result);
                return result;
            }
        }

        public System.Boolean? SecondLevelAddressTranslationExtensions
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SecondLevelAddressTranslationExtensions", out result);
                return result;
            }
        }

        public System.String SerialNumber
        {
            get
            {
                System.String result;
                this.GetProperty("SerialNumber", out result);
                return result;
            }
        }

        public System.String SocketDesignation
        {
            get
            {
                System.String result;
                this.GetProperty("SocketDesignation", out result);
                return result;
            }
        }

        public System.UInt32? ThreadCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ThreadCount", out result);
                return result;
            }
        }

        public System.String Version
        {
            get
            {
                System.String result;
                this.GetProperty("Version", out result);
                return result;
            }
        }

        public System.Boolean? VirtualizationFirmwareEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("VirtualizationFirmwareEnabled", out result);
                return result;
            }
        }

        public System.Boolean? VMMonitorModeExtensions
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("VMMonitorModeExtensions", out result);
                return result;
            }
        }

        public System.UInt32? VoltageCaps
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VoltageCaps", out result);
                return result;
            }
        }
    }
}