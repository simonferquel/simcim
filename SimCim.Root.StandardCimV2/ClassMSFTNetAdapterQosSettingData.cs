using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterQosSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterQosSettingData()
        {
        }

        public MSFTNetAdapterQosSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public MSFTNetAdapterQosCapabilities CurrentCapabilities
        {
            get
            {
                MSFTNetAdapterQosCapabilities result;
                this.GetInfrastructureObjectProperty("CurrentCapabilities", out result);
                return result;
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

        public MSFTNetAdapterQosCapabilities HardwareCapabilities
        {
            get
            {
                MSFTNetAdapterQosCapabilities result;
                this.GetInfrastructureObjectProperty("HardwareCapabilities", out result);
                return result;
            }
        }

        public MSFTNetAdapterQosSettings OperationalSettings
        {
            get
            {
                MSFTNetAdapterQosSettings result;
                this.GetInfrastructureObjectProperty("OperationalSettings", out result);
                return result;
            }
        }

        public MSFTNetAdapterQosSettings RemoteSettings
        {
            get
            {
                MSFTNetAdapterQosSettings result;
                this.GetInfrastructureObjectProperty("RemoteSettings", out result);
                return result;
            }
        }

        public (System.UInt32 retval, MSFTNetAdapterQosSettingData outCmdletOutput) Enable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterQosSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["CmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapterQosSettingData outCmdletOutput) Disable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterQosSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["CmdletOutput"].Value));
        }
    }
}