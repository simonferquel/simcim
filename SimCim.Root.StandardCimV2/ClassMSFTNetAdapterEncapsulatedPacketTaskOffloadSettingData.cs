using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterEncapsulatedPacketTaskOffloadSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterEncapsulatedPacketTaskOffloadSettingData()
        {
        }

        public MSFTNetAdapterEncapsulatedPacketTaskOffloadSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public MSFTNetAdapterEncapsulatedPacketTaskOffloadCapabilities EncapsulatedPacketTaskOffloadHardwareCapabilitiesNvgre
        {
            get
            {
                MSFTNetAdapterEncapsulatedPacketTaskOffloadCapabilities result;
                this.GetInfrastructureObjectProperty("EncapsulatedPacketTaskOffloadHardwareCapabilitiesNvgre", out result);
                return result;
            }
        }

        public MSFTNetAdapterEncapsulatedPacketTaskOffloadCapabilitiesEx EncapsulatedPacketTaskOffloadHardwareCapabilitiesVxlan
        {
            get
            {
                MSFTNetAdapterEncapsulatedPacketTaskOffloadCapabilitiesEx result;
                this.GetInfrastructureObjectProperty("EncapsulatedPacketTaskOffloadHardwareCapabilitiesVxlan", out result);
                return result;
            }
        }

        public System.UInt16? EncapsulationType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EncapsulationType", out result);
                return result;
            }

            set
            {
                this.SetProperty("EncapsulationType", value);
            }
        }

        public System.Boolean? IsVxlanUDPPortConfigurable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsVxlanUDPPortConfigurable", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsVxlanUDPPortConfigurable", value);
            }
        }

        public System.Boolean? NvgreEncapsulatedPacketTaskOffloadEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NvgreEncapsulatedPacketTaskOffloadEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("NvgreEncapsulatedPacketTaskOffloadEnabled", value);
            }
        }

        public System.Boolean? VxlanEncapsulatedPacketTaskOffloadEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("VxlanEncapsulatedPacketTaskOffloadEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("VxlanEncapsulatedPacketTaskOffloadEnabled", value);
            }
        }

        public System.UInt16? VxlanUDPPortNumber
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("VxlanUDPPortNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("VxlanUDPPortNumber", value);
            }
        }

        public (System.UInt32 retval, MSFTNetAdapterEncapsulatedPacketTaskOffloadSettingData outcmdletOutput) Enable(System.UInt16? inEncapsulationType)
        {
            var parameters = new CimMethodParametersCollection();
            if (inEncapsulationType.HasValue)
                parameters.Add(CimMethodParameter.Create("EncapsulationType", inEncapsulationType.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterEncapsulatedPacketTaskOffloadSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapterEncapsulatedPacketTaskOffloadSettingData outcmdletOutput) Disable(System.UInt16? inEncapsulationType)
        {
            var parameters = new CimMethodParametersCollection();
            if (inEncapsulationType.HasValue)
                parameters.Add(CimMethodParameter.Create("EncapsulationType", inEncapsulationType.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterEncapsulatedPacketTaskOffloadSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }
    }
}