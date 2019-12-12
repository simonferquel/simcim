using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMMemory : CIMStorageExtent
    {
        protected CIMMemory()
        {
        }

        protected CIMMemory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

            set
            {
                this.SetProperty("AdditionalErrorData", value);
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

            set
            {
                this.SetProperty("CorrectableError", value);
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

            set
            {
                this.SetProperty("EndingAddress", value);
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

            set
            {
                this.SetProperty("ErrorAccess", value);
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

            set
            {
                this.SetProperty("ErrorAddress", value);
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

            set
            {
                this.SetProperty("ErrorData", value);
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

            set
            {
                this.SetProperty("ErrorDataOrder", value);
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

            set
            {
                this.SetProperty("ErrorInfo", value);
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

            set
            {
                this.SetProperty("ErrorResolution", value);
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

            set
            {
                this.SetProperty("ErrorTime", value);
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

            set
            {
                this.SetProperty("ErrorTransferSize", value);
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

            set
            {
                this.SetProperty("OtherErrorDescription", value);
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

            set
            {
                this.SetProperty("StartingAddress", value);
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

            set
            {
                this.SetProperty("SystemLevelAddress", value);
            }
        }

        public System.Boolean? Volatile
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("volatile", out result);
                return result;
            }

            set
            {
                this.SetProperty("volatile", value);
            }
        }
    }
}