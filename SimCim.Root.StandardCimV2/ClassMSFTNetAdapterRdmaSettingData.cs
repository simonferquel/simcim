using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterRdmaSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterRdmaSettingData()
        {
        }

        public MSFTNetAdapterRdmaSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.UInt32? ETS
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ETS", out result);
                return result;
            }
        }

        public System.UInt32? MaxCompletionQueueCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxCompletionQueueCount", out result);
                return result;
            }
        }

        public System.UInt32? MaxInboundReadLimit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxInboundReadLimit", out result);
                return result;
            }
        }

        public System.UInt32? MaxMemoryRegionCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxMemoryRegionCount", out result);
                return result;
            }
        }

        public System.UInt32? MaxMemoryWindowCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxMemoryWindowCount", out result);
                return result;
            }
        }

        public System.UInt32? MaxOutboundReadLimit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxOutboundReadLimit", out result);
                return result;
            }
        }

        public System.UInt32? MaxProtectionDomainCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxProtectionDomainCount", out result);
                return result;
            }
        }

        public System.UInt32? MaxQueuePairCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxQueuePairCount", out result);
                return result;
            }
        }

        public System.UInt32? MaxSharedReceiveQueueCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxSharedReceiveQueueCount", out result);
                return result;
            }
        }

        public System.UInt32? PFC
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PFC", out result);
                return result;
            }
        }

        public MSFTNetAdapterRdmaAdapterInfo RdmaAdapterInfo
        {
            get
            {
                MSFTNetAdapterRdmaAdapterInfo result;
                this.GetInfrastructureObjectProperty("RdmaAdapterInfo", out result);
                return result;
            }
        }

        public MSFTNetAdapterRdmaMissingCounterInfo RdmaMissingCounterInfo
        {
            get
            {
                MSFTNetAdapterRdmaMissingCounterInfo result;
                this.GetInfrastructureObjectProperty("RdmaMissingCounterInfo", out result);
                return result;
            }
        }

        public (System.UInt32 retval, MSFTNetAdapterRdmaSettingData outcmdletOutput) Enable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterRdmaSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapterRdmaSettingData outcmdletOutput) Disable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterRdmaSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }
    }
}