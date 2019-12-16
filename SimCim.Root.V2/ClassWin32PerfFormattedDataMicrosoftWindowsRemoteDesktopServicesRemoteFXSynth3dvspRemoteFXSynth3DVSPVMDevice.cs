using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMDevice : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMDevice()
        {
        }

        public Win32PerfFormattedDataMicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvspRemoteFXSynth3DVSPVMDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? NumberofconnectedVMTchannels
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofconnectedVMTchannels", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofconnectedVMTchannels", value);
            }
        }

        public System.UInt32? NumberofcreatedVMTchannels
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofcreatedVMTchannels", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofcreatedVMTchannels", value);
            }
        }

        public System.UInt32? NumberofdisconnectedVMTchannels
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofdisconnectedVMTchannels", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofdisconnectedVMTchannels", value);
            }
        }

        public System.UInt32? NumberofRDVGMrestartednotifications
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofRDVGMrestartednotifications", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofRDVGMrestartednotifications", value);
            }
        }

        public System.UInt32? NumberofwaitingVMTchannels
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofwaitingVMTchannels", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofwaitingVMTchannels", value);
            }
        }

        public System.UInt32? TotalnumberofcreatedVMTchannels
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalnumberofcreatedVMTchannels", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalnumberofcreatedVMTchannels", value);
            }
        }
    }
}