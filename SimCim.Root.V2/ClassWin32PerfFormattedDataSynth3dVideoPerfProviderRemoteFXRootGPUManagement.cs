using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataSynth3dVideoPerfProviderRemoteFXRootGPUManagement : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataSynth3dVideoPerfProviderRemoteFXRootGPUManagement()
        {
        }

        public Win32PerfFormattedDataSynth3dVideoPerfProviderRemoteFXRootGPUManagement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? ResourcesVMsrunningRemoteFX
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ResourcesVMsrunningRemoteFX", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResourcesVMsrunningRemoteFX", value);
            }
        }

        public System.UInt64? VRAMAvailableMBperGPU
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VRAMAvailableMBperGPU", out result);
                return result;
            }

            set
            {
                this.SetProperty("VRAMAvailableMBperGPU", value);
            }
        }

        public System.UInt64? VRAMReservedPercentperGPU
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VRAMReservedPercentperGPU", out result);
                return result;
            }

            set
            {
                this.SetProperty("VRAMReservedPercentperGPU", value);
            }
        }
    }
}