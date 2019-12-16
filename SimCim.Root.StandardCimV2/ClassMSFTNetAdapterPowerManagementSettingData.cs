using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterPowerManagementSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterPowerManagementSettingData()
        {
        }

        public MSFTNetAdapterPowerManagementSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AllowComputerToTurnOffDevice
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AllowComputerToTurnOffDevice", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowComputerToTurnOffDevice", value);
            }
        }

        public System.UInt32? ArpOffload
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ArpOffload", out result);
                return result;
            }

            set
            {
                this.SetProperty("ArpOffload", value);
            }
        }

        public System.UInt32? D0PacketCoalescing
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("D0PacketCoalescing", out result);
                return result;
            }

            set
            {
                this.SetProperty("D0PacketCoalescing", value);
            }
        }

        public System.UInt32? DeviceSleepOnDisconnect
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DeviceSleepOnDisconnect", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeviceSleepOnDisconnect", value);
            }
        }

        public System.UInt32? NSOffload
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NSOffload", out result);
                return result;
            }

            set
            {
                this.SetProperty("NSOffload", value);
            }
        }

        public IEnumerable<MSFTNetAdapterPowerManagementOffload> OffloadParameters
        {
            get
            {
                IEnumerable<MSFTNetAdapterPowerManagementOffload> result;
                this.GetInfrastructureObjectProperty("OffloadParameters", out result);
                return result;
            }
        }

        public System.UInt32? RsnRekeyOffload
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RsnRekeyOffload", out result);
                return result;
            }

            set
            {
                this.SetProperty("RsnRekeyOffload", value);
            }
        }

        public System.UInt32? SelectiveSuspend
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SelectiveSuspend", out result);
                return result;
            }

            set
            {
                this.SetProperty("SelectiveSuspend", value);
            }
        }

        public System.UInt32? WakeOnMagicPacket
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WakeOnMagicPacket", out result);
                return result;
            }

            set
            {
                this.SetProperty("WakeOnMagicPacket", value);
            }
        }

        public System.UInt32? WakeOnPattern
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WakeOnPattern", out result);
                return result;
            }

            set
            {
                this.SetProperty("WakeOnPattern", value);
            }
        }

        public IEnumerable<MSFTNetAdapterPowerManagementWakePattern> WakePatterns
        {
            get
            {
                IEnumerable<MSFTNetAdapterPowerManagementWakePattern> result;
                this.GetInfrastructureObjectProperty("WakePatterns", out result);
                return result;
            }
        }

        public (System.UInt32 retval, MSFTNetAdapterPowerManagementSettingData outcmdletOutput) Enable(System.Boolean? inArpOffload, System.Boolean? inD0PacketCoalescing, System.Boolean? inDeviceSleepOnDisconnect, System.Boolean? inNSOffload, System.Boolean? inRsnRekeyOffload, System.Boolean? inSelectiveSuspend, System.Boolean? inWakeOnMagicPacket, System.Boolean? inWakeOnPattern)
        {
            var parameters = new CimMethodParametersCollection();
            if (inArpOffload.HasValue)
                parameters.Add(CimMethodParameter.Create("ArpOffload", inArpOffload.Value, CimFlags.None));
            if (inD0PacketCoalescing.HasValue)
                parameters.Add(CimMethodParameter.Create("D0PacketCoalescing", inD0PacketCoalescing.Value, CimFlags.None));
            if (inDeviceSleepOnDisconnect.HasValue)
                parameters.Add(CimMethodParameter.Create("DeviceSleepOnDisconnect", inDeviceSleepOnDisconnect.Value, CimFlags.None));
            if (inNSOffload.HasValue)
                parameters.Add(CimMethodParameter.Create("NSOffload", inNSOffload.Value, CimFlags.None));
            if (inRsnRekeyOffload.HasValue)
                parameters.Add(CimMethodParameter.Create("RsnRekeyOffload", inRsnRekeyOffload.Value, CimFlags.None));
            if (inSelectiveSuspend.HasValue)
                parameters.Add(CimMethodParameter.Create("SelectiveSuspend", inSelectiveSuspend.Value, CimFlags.None));
            if (inWakeOnMagicPacket.HasValue)
                parameters.Add(CimMethodParameter.Create("WakeOnMagicPacket", inWakeOnMagicPacket.Value, CimFlags.None));
            if (inWakeOnPattern.HasValue)
                parameters.Add(CimMethodParameter.Create("WakeOnPattern", inWakeOnPattern.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterPowerManagementSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapterPowerManagementSettingData outcmdletOutput) Disable(System.Boolean? inArpOffload, System.Boolean? inD0PacketCoalescing, System.Boolean? inDeviceSleepOnDisconnect, System.Boolean? inNSOffload, System.Boolean? inRsnRekeyOffload, System.Boolean? inSelectiveSuspend, System.Boolean? inWakeOnMagicPacket, System.Boolean? inWakeOnPattern)
        {
            var parameters = new CimMethodParametersCollection();
            if (inArpOffload.HasValue)
                parameters.Add(CimMethodParameter.Create("ArpOffload", inArpOffload.Value, CimFlags.None));
            if (inD0PacketCoalescing.HasValue)
                parameters.Add(CimMethodParameter.Create("D0PacketCoalescing", inD0PacketCoalescing.Value, CimFlags.None));
            if (inDeviceSleepOnDisconnect.HasValue)
                parameters.Add(CimMethodParameter.Create("DeviceSleepOnDisconnect", inDeviceSleepOnDisconnect.Value, CimFlags.None));
            if (inNSOffload.HasValue)
                parameters.Add(CimMethodParameter.Create("NSOffload", inNSOffload.Value, CimFlags.None));
            if (inRsnRekeyOffload.HasValue)
                parameters.Add(CimMethodParameter.Create("RsnRekeyOffload", inRsnRekeyOffload.Value, CimFlags.None));
            if (inSelectiveSuspend.HasValue)
                parameters.Add(CimMethodParameter.Create("SelectiveSuspend", inSelectiveSuspend.Value, CimFlags.None));
            if (inWakeOnMagicPacket.HasValue)
                parameters.Add(CimMethodParameter.Create("WakeOnMagicPacket", inWakeOnMagicPacket.Value, CimFlags.None));
            if (inWakeOnPattern.HasValue)
                parameters.Add(CimMethodParameter.Create("WakeOnPattern", inWakeOnPattern.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterPowerManagementSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }
    }
}