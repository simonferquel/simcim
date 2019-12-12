using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP : Win32PerfRawData
    {
        public Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP()
        {
        }

        public Win32PerfRawDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSP(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? NumberofcreatedVMdevices
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofcreatedVMdevices", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofcreatedVMdevices", value);
            }
        }
    }
}