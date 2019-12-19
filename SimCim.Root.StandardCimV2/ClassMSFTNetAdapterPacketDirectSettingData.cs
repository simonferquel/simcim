using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterPacketDirectSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterPacketDirectSettingData()
        {
        }

        public MSFTNetAdapterPacketDirectSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public MSFTNetAdapterPacketDirectCapabilities Capabilities
        {
            get
            {
                MSFTNetAdapterPacketDirectCapabilities result;
                this.GetInfrastructureObjectProperty("Capabilities", out result);
                return result;
            }
        }

        public System.UInt32? DiagnosticCode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DiagnosticCode", out result);
                return result;
            }
        }

        public System.Byte? DmaAddressWidth
        {
            get
            {
                System.Byte? result;
                this.GetProperty("DmaAddressWidth", out result);
                return result;
            }
        }

        public System.UInt32? DomainId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DomainId", out result);
                return result;
            }

            set
            {
                this.SetProperty("DomainId", value);
            }
        }

        public System.Boolean? Enabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Enabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("Enabled", value);
            }
        }

        public System.Boolean? Operational
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Operational", out result);
                return result;
            }
        }

        public (System.UInt32 retval, MSFTNetAdapterPacketDirectSettingData outCmdletOutput) Enable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterPacketDirectSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["CmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapterPacketDirectSettingData outCmdletOutput) Disable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterPacketDirectSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["CmdletOutput"].Value));
        }
    }
}