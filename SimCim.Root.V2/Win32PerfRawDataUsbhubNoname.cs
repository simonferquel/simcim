using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataUsbhubNoname : Win32PerfRawData
    {
        public Win32PerfRawDataUsbhubNoname()
        {
        }

        public Win32PerfRawDataUsbhubNoname(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CpuXpress9Compressionaveragelatencyus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CpuXpress9Compressionaveragelatencyus", out result);
                return result;
            }

            set
            {
                this.SetProperty("CpuXpress9Compressionaveragelatencyus", value);
            }
        }

        public System.UInt32? CpuXpress9CompressionOpsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CpuXpress9CompressionOpsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CpuXpress9CompressionOpsPersec", value);
            }
        }

        public System.UInt32? CpuXpress9Compressionratio
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CpuXpress9Compressionratio", out result);
                return result;
            }

            set
            {
                this.SetProperty("CpuXpress9Compressionratio", value);
            }
        }

        public System.UInt32? CpuXpress9DecompressedBytesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CpuXpress9DecompressedBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CpuXpress9DecompressedBytesPersec", value);
            }
        }

        public System.UInt32? CpuXpress9Decompressionaveragelatencyus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CpuXpress9Decompressionaveragelatencyus", out result);
                return result;
            }

            set
            {
                this.SetProperty("CpuXpress9Decompressionaveragelatencyus", value);
            }
        }

        public System.UInt32? CpuXpress9DecompressionOpsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CpuXpress9DecompressionOpsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CpuXpress9DecompressionOpsPersec", value);
            }
        }

        public System.UInt64? FpgaXpress9CompressedBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FpgaXpress9CompressedBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FpgaXpress9CompressedBytesPersec", value);
            }
        }

        public System.UInt32? FpgaXpress9CompressedBytesPersecBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FpgaXpress9CompressedBytesPersec_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("FpgaXpress9CompressedBytesPersec_Base", value);
            }
        }

        public System.UInt64? FpgaXpress9Compressionaveragelatencyus
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FpgaXpress9Compressionaveragelatencyus", out result);
                return result;
            }

            set
            {
                this.SetProperty("FpgaXpress9Compressionaveragelatencyus", value);
            }
        }

        public System.UInt32? FpgaXpress9CompressionaveragelatencyusBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FpgaXpress9Compressionaveragelatencyus_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("FpgaXpress9Compressionaveragelatencyus_Base", value);
            }
        }

        public System.UInt32? FpgaXpress9CompressionOpsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FpgaXpress9CompressionOpsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FpgaXpress9CompressionOpsPersec", value);
            }
        }

        public System.UInt32? FpgaXpress9Compressionratio
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FpgaXpress9Compressionratio", out result);
                return result;
            }

            set
            {
                this.SetProperty("FpgaXpress9Compressionratio", value);
            }
        }

        public System.UInt32? FpgaXpress9DecompressedBytesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FpgaXpress9DecompressedBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FpgaXpress9DecompressedBytesPersec", value);
            }
        }

        public System.UInt32? FpgaXpress9Decompressionaveragelatencyus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FpgaXpress9Decompressionaveragelatencyus", out result);
                return result;
            }

            set
            {
                this.SetProperty("FpgaXpress9Decompressionaveragelatencyus", value);
            }
        }

        public System.UInt32? FpgaXpress9DecompressionOpsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FpgaXpress9DecompressionOpsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FpgaXpress9DecompressionOpsPersec", value);
            }
        }

        public System.UInt32? Noname
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Noname", out result);
                return result;
            }

            set
            {
                this.SetProperty("Noname", value);
            }
        }
    }
}