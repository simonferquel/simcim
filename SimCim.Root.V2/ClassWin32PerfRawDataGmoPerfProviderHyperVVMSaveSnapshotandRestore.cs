using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataGmoPerfProviderHyperVVMSaveSnapshotandRestore : Win32PerfRawData
    {
        public Win32PerfRawDataGmoPerfProviderHyperVVMSaveSnapshotandRestore()
        {
        }

        public Win32PerfRawDataGmoPerfProviderHyperVVMSaveSnapshotandRestore(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? OperationTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OperationTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("OperationTime", value);
            }
        }

        public System.UInt32? RequestsActive
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsActive", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsActive", value);
            }
        }

        public System.UInt32? RequestsDispatched
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsDispatched", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsDispatched", value);
            }
        }

        public System.UInt32? RequestsHighPriority
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsHighPriority", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsHighPriority", value);
            }
        }

        public System.UInt32? RequestsProcessed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsProcessed", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsProcessed", value);
            }
        }

        public System.UInt32? ThreadsSpawned
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ThreadsSpawned", out result);
                return result;
            }

            set
            {
                this.SetProperty("ThreadsSpawned", value);
            }
        }
    }
}