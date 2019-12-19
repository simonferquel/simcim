using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterSriovSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterSriovSettingData()
        {
        }

        public MSFTNetAdapterSriovSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public MSFTNetAdapterSriovCapabilities CurrentCapabilities
        {
            get
            {
                MSFTNetAdapterSriovCapabilities result;
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

        public MSFTNetAdapterSriovCapabilities HardwareCapabilities
        {
            get
            {
                MSFTNetAdapterSriovCapabilities result;
                this.GetInfrastructureObjectProperty("HardwareCapabilities", out result);
                return result;
            }
        }

        public System.UInt32? NumActiveDefaultVPortMacAddresses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumActiveDefaultVPortMacAddresses", out result);
                return result;
            }
        }

        public System.UInt32? NumActiveDefaultVPortVlanIds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumActiveDefaultVPortVlanIds", out result);
                return result;
            }
        }

        public System.UInt32? NumActiveNonDefaultVPortMacAddresses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumActiveNonDefaultVPortMacAddresses", out result);
                return result;
            }
        }

        public System.UInt32? NumActiveNonDefaultVPortVlanIds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumActiveNonDefaultVPortVlanIds", out result);
                return result;
            }
        }

        public System.UInt32? NumActiveVPorts
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumActiveVPorts", out result);
                return result;
            }
        }

        public System.UInt32? NumAllocatedVFs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumAllocatedVFs", out result);
                return result;
            }
        }

        public System.UInt32? NumQueuePairsForDefaultVPort
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumQueuePairsForDefaultVPort", out result);
                return result;
            }
        }

        public System.UInt32? NumQueuePairsForNonDefaultVPorts
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumQueuePairsForNonDefaultVPorts", out result);
                return result;
            }
        }

        public System.UInt32? NumVFs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumVFs", out result);
                return result;
            }
        }

        public System.UInt32? NumVPorts
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumVPorts", out result);
                return result;
            }
        }

        public System.UInt32? SriovSupport
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SriovSupport", out result);
                return result;
            }
        }

        public System.String SwitchName
        {
            get
            {
                System.String result;
                this.GetProperty("SwitchName", out result);
                return result;
            }
        }

        public System.UInt16? SwitchType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SwitchType", out result);
                return result;
            }
        }

        public (System.UInt32 retval, MSFTNetAdapterSriovSettingData outcmdletOutput) Enable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterSriovSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapterSriovSettingData outcmdletOutput) Disable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterSriovSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }
    }
}