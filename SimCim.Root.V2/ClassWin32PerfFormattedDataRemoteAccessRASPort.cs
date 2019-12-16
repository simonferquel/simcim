using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataRemoteAccessRASPort : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataRemoteAccessRASPort()
        {
        }

        public Win32PerfFormattedDataRemoteAccessRASPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AlignmentErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AlignmentErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("AlignmentErrors", value);
            }
        }

        public System.UInt32? BufferOverrunErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BufferOverrunErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("BufferOverrunErrors", value);
            }
        }

        public System.UInt64? BytesReceived
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesReceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesReceived", value);
            }
        }

        public System.UInt32? BytesReceivedPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BytesReceivedPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesReceivedPerSec", value);
            }
        }

        public System.UInt64? BytesTransmitted
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesTransmitted", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesTransmitted", value);
            }
        }

        public System.UInt32? BytesTransmittedPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BytesTransmittedPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesTransmittedPerSec", value);
            }
        }

        public System.UInt32? CRCErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CRCErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("CRCErrors", value);
            }
        }

        public System.UInt32? FramesReceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FramesReceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("FramesReceived", value);
            }
        }

        public System.UInt32? FramesReceivedPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FramesReceivedPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FramesReceivedPerSec", value);
            }
        }

        public System.UInt32? FramesTransmitted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FramesTransmitted", out result);
                return result;
            }

            set
            {
                this.SetProperty("FramesTransmitted", value);
            }
        }

        public System.UInt32? FramesTransmittedPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FramesTransmittedPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FramesTransmittedPerSec", value);
            }
        }

        public System.UInt32? PercentCompressionIn
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentCompressionIn", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentCompressionIn", value);
            }
        }

        public System.UInt32? PercentCompressionOut
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentCompressionOut", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentCompressionOut", value);
            }
        }

        public System.UInt32? SerialOverrunErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SerialOverrunErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("SerialOverrunErrors", value);
            }
        }

        public System.UInt32? TimeoutErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TimeoutErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimeoutErrors", value);
            }
        }

        public System.UInt32? TotalErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalErrors", value);
            }
        }

        public System.UInt32? TotalErrorsPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalErrorsPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalErrorsPerSec", value);
            }
        }
    }
}