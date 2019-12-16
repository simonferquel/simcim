using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32POTSModem : CIMPotsModem
    {
        public Win32POTSModem()
        {
        }

        public Win32POTSModem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AttachedTo
        {
            get
            {
                System.String result;
                this.GetProperty("AttachedTo", out result);
                return result;
            }
        }

        public System.String BlindOff
        {
            get
            {
                System.String result;
                this.GetProperty("BlindOff", out result);
                return result;
            }
        }

        public System.String BlindOn
        {
            get
            {
                System.String result;
                this.GetProperty("BlindOn", out result);
                return result;
            }
        }

        public System.String CompatibilityFlags
        {
            get
            {
                System.String result;
                this.GetProperty("CompatibilityFlags", out result);
                return result;
            }
        }

        public System.String CompressionOff
        {
            get
            {
                System.String result;
                this.GetProperty("CompressionOff", out result);
                return result;
            }
        }

        public System.String CompressionOn
        {
            get
            {
                System.String result;
                this.GetProperty("CompressionOn", out result);
                return result;
            }
        }

        public System.String ConfigurationDialog
        {
            get
            {
                System.String result;
                this.GetProperty("ConfigurationDialog", out result);
                return result;
            }
        }

        public System.Byte[] DCB
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("DCB", out result);
                return result;
            }
        }

        public System.Byte[] Default
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("Default", out result);
                return result;
            }
        }

        public System.String DeviceLoader
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceLoader", out result);
                return result;
            }
        }

        public System.String DeviceType
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceType", out result);
                return result;
            }
        }

        public System.DateTime? DriverDate
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("DriverDate", out result);
                return result;
            }
        }

        public System.String ErrorControlForced
        {
            get
            {
                System.String result;
                this.GetProperty("ErrorControlForced", out result);
                return result;
            }
        }

        public System.String ErrorControlOff
        {
            get
            {
                System.String result;
                this.GetProperty("ErrorControlOff", out result);
                return result;
            }
        }

        public System.String ErrorControlOn
        {
            get
            {
                System.String result;
                this.GetProperty("ErrorControlOn", out result);
                return result;
            }
        }

        public System.String FlowControlHard
        {
            get
            {
                System.String result;
                this.GetProperty("FlowControlHard", out result);
                return result;
            }
        }

        public System.String FlowControlOff
        {
            get
            {
                System.String result;
                this.GetProperty("FlowControlOff", out result);
                return result;
            }
        }

        public System.String FlowControlSoft
        {
            get
            {
                System.String result;
                this.GetProperty("FlowControlSoft", out result);
                return result;
            }
        }

        public System.String InactivityScale
        {
            get
            {
                System.String result;
                this.GetProperty("InactivityScale", out result);
                return result;
            }
        }

        public System.UInt32? Index
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Index", out result);
                return result;
            }
        }

        public System.String IndexEx
        {
            get
            {
                System.String result;
                this.GetProperty("IndexEx", out result);
                return result;
            }
        }

        public System.String Model
        {
            get
            {
                System.String result;
                this.GetProperty("Model", out result);
                return result;
            }
        }

        public System.String ModemInfPath
        {
            get
            {
                System.String result;
                this.GetProperty("ModemInfPath", out result);
                return result;
            }
        }

        public System.String ModemInfSection
        {
            get
            {
                System.String result;
                this.GetProperty("ModemInfSection", out result);
                return result;
            }
        }

        public System.String ModulationBell
        {
            get
            {
                System.String result;
                this.GetProperty("ModulationBell", out result);
                return result;
            }
        }

        public System.String ModulationCCITT
        {
            get
            {
                System.String result;
                this.GetProperty("ModulationCCITT", out result);
                return result;
            }
        }

        public System.String PortSubClass
        {
            get
            {
                System.String result;
                this.GetProperty("PortSubClass", out result);
                return result;
            }
        }

        public System.String Prefix
        {
            get
            {
                System.String result;
                this.GetProperty("Prefix", out result);
                return result;
            }
        }

        public System.Byte[] Properties
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("Properties", out result);
                return result;
            }
        }

        public System.String ProviderName
        {
            get
            {
                System.String result;
                this.GetProperty("ProviderName", out result);
                return result;
            }
        }

        public System.String Pulse
        {
            get
            {
                System.String result;
                this.GetProperty("Pulse", out result);
                return result;
            }
        }

        public new System.String Reset
        {
            get
            {
                System.String result;
                this.GetProperty("Reset", out result);
                return result;
            }
        }

        public System.String ResponsesKeyName
        {
            get
            {
                System.String result;
                this.GetProperty("ResponsesKeyName", out result);
                return result;
            }
        }

        public System.String SpeakerModeDial
        {
            get
            {
                System.String result;
                this.GetProperty("SpeakerModeDial", out result);
                return result;
            }
        }

        public System.String SpeakerModeOff
        {
            get
            {
                System.String result;
                this.GetProperty("SpeakerModeOff", out result);
                return result;
            }
        }

        public System.String SpeakerModeOn
        {
            get
            {
                System.String result;
                this.GetProperty("SpeakerModeOn", out result);
                return result;
            }
        }

        public System.String SpeakerModeSetup
        {
            get
            {
                System.String result;
                this.GetProperty("SpeakerModeSetup", out result);
                return result;
            }
        }

        public System.String SpeakerVolumeHigh
        {
            get
            {
                System.String result;
                this.GetProperty("SpeakerVolumeHigh", out result);
                return result;
            }
        }

        public System.String SpeakerVolumeLow
        {
            get
            {
                System.String result;
                this.GetProperty("SpeakerVolumeLow", out result);
                return result;
            }
        }

        public System.String SpeakerVolumeMed
        {
            get
            {
                System.String result;
                this.GetProperty("SpeakerVolumeMed", out result);
                return result;
            }
        }

        public System.String StringFormat
        {
            get
            {
                System.String result;
                this.GetProperty("StringFormat", out result);
                return result;
            }
        }

        public System.String Terminator
        {
            get
            {
                System.String result;
                this.GetProperty("Terminator", out result);
                return result;
            }
        }

        public System.String Tone
        {
            get
            {
                System.String result;
                this.GetProperty("Tone", out result);
                return result;
            }
        }

        public System.String VoiceSwitchFeature
        {
            get
            {
                System.String result;
                this.GetProperty("VoiceSwitchFeature", out result);
                return result;
            }
        }
    }
}