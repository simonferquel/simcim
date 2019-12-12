using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataOfflineFilesOfflineFiles : Win32PerfRawData
    {
        public Win32PerfRawDataOfflineFilesOfflineFiles()
        {
        }

        public Win32PerfRawDataOfflineFilesOfflineFiles(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.UInt64? BytesReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesReceivedPersec", value);
            }
        }

        public System.UInt32? BytesReceivedPersecBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BytesReceivedPersec_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesReceivedPersec_Base", value);
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

        public System.UInt64? BytesTransmittedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesTransmittedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesTransmittedPersec", value);
            }
        }

        public System.UInt32? BytesTransmittedPersecBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BytesTransmittedPersec_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesTransmittedPersec_Base", value);
            }
        }
    }
}