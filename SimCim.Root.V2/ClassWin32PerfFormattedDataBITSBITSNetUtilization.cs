using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataBITSBITSNetUtilization : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataBITSBITSNetUtilization()
        {
        }

        public Win32PerfFormattedDataBITSBITSNetUtilization(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BITSDownloadBlockSizeBytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BITSDownloadBlockSizeBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("BITSDownloadBlockSizeBytes", value);
            }
        }

        public System.UInt32? BITSDownloadResponseIntervalmsec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BITSDownloadResponseIntervalmsec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BITSDownloadResponseIntervalmsec", value);
            }
        }

        public System.UInt32? EstimatedbandwidthavailabletotheremotesystemBitsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EstimatedbandwidthavailabletotheremotesystemBitsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("EstimatedbandwidthavailabletotheremotesystemBitsPersec", value);
            }
        }

        public System.UInt32? IGDSpeedBitsPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IGDSpeedBitsPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IGDSpeedBitsPerSec", value);
            }
        }

        public System.UInt32? NetcardSpeedBitsPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NetcardSpeedBitsPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NetcardSpeedBitsPerSec", value);
            }
        }

        public System.UInt32? PercentIGDFree
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentIGDFree", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentIGDFree", value);
            }
        }

        public System.UInt32? PercentNetcardFree
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentNetcardFree", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentNetcardFree", value);
            }
        }

        public System.UInt32? RemoteServerSpeedBitsPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RemoteServerSpeedBitsPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteServerSpeedBitsPerSec", value);
            }
        }
    }
}