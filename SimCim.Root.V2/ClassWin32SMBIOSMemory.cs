using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32SMBIOSMemory : CIMStorageExtent
    {
        protected Win32SMBIOSMemory()
        {
        }

        protected Win32SMBIOSMemory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte[] AdditionalErrorData
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("AdditionalErrorData", out result);
                return result;
            }
        }

        public System.Boolean? CorrectableError
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CorrectableError", out result);
                return result;
            }
        }

        public System.UInt64? EndingAddress
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EndingAddress", out result);
                return result;
            }
        }

        public System.UInt16? ErrorAccess
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ErrorAccess", out result);
                return result;
            }
        }

        public System.UInt64? ErrorAddress
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ErrorAddress", out result);
                return result;
            }
        }

        public System.Byte[] ErrorData
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("ErrorData", out result);
                return result;
            }
        }

        public System.UInt16? ErrorDataOrder
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ErrorDataOrder", out result);
                return result;
            }
        }

        public System.UInt16? ErrorInfo
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ErrorInfo", out result);
                return result;
            }
        }

        public System.UInt64? ErrorResolution
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ErrorResolution", out result);
                return result;
            }
        }

        public System.DateTime? ErrorTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("ErrorTime", out result);
                return result;
            }
        }

        public System.UInt32? ErrorTransferSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorTransferSize", out result);
                return result;
            }
        }

        public System.String OtherErrorDescription
        {
            get
            {
                System.String result;
                this.GetProperty("OtherErrorDescription", out result);
                return result;
            }
        }

        public System.UInt64? StartingAddress
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("StartingAddress", out result);
                return result;
            }
        }

        public System.Boolean? SystemLevelAddress
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SystemLevelAddress", out result);
                return result;
            }
        }
    }
}