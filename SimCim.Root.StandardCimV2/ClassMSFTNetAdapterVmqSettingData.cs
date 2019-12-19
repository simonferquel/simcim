using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterVmqSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterVmqSettingData()
        {
        }

        public MSFTNetAdapterVmqSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AnyVlanSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AnyVlanSupported", out result);
                return result;
            }
        }

        public System.UInt16? BaseProcessorGroup
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("BaseProcessorGroup", out result);
                return result;
            }

            set
            {
                this.SetProperty("BaseProcessorGroup", value);
            }
        }

        public System.Byte? BaseProcessorNumber
        {
            get
            {
                System.Byte? result;
                this.GetProperty("BaseProcessorNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("BaseProcessorNumber", value);
            }
        }

        public System.Boolean? DynamicProcessorAffinityChangeSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DynamicProcessorAffinityChangeSupported", out result);
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

        public System.Boolean? InterruptVectorCoalescingSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("InterruptVectorCoalescingSupported", out result);
                return result;
            }
        }

        public System.Boolean? LookaheadSplitSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("LookaheadSplitSupported", out result);
                return result;
            }
        }

        public System.UInt32? MaxLookaheadSplitSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxLookaheadSplitSize", out result);
                return result;
            }
        }

        public System.Byte? MaxProcessorNumber
        {
            get
            {
                System.Byte? result;
                this.GetProperty("MaxProcessorNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxProcessorNumber", value);
            }
        }

        public System.UInt32? MaxProcessors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxProcessors", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxProcessors", value);
            }
        }

        public System.UInt32? MinLookaheadSplitSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MinLookaheadSplitSize", out result);
                return result;
            }
        }

        public System.UInt16? NumaNode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NumaNode", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumaNode", value);
            }
        }

        public System.UInt32? NumberOfReceiveQueues
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfReceiveQueues", out result);
                return result;
            }
        }

        public System.UInt32? NumMacAddressesPerPort
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumMacAddressesPerPort", out result);
                return result;
            }
        }

        public System.UInt32? NumVlansPerPort
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumVlansPerPort", out result);
                return result;
            }
        }

        public System.UInt32? TotalNumberOfMacAddresses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalNumberOfMacAddresses", out result);
                return result;
            }
        }

        public System.Boolean? VlanFilteringSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("VlanFilteringSupported", out result);
                return result;
            }
        }

        public (System.UInt32 retval, MSFTNetAdapterVmqSettingData outcmdletOutput) Enable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterVmqSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapterVmqSettingData outcmdletOutput) Disable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterVmqSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }
    }
}