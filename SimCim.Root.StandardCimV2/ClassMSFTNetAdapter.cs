using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapter : CIMNetworkPort
    {
        public MSFTNetAdapter()
        {
        }

        public MSFTNetAdapter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AdminLocked
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AdminLocked", out result);
                return result;
            }
        }

        public System.String ComponentID
        {
            get
            {
                System.String result;
                this.GetProperty("ComponentID", out result);
                return result;
            }
        }

        public System.Boolean? ConnectorPresent
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ConnectorPresent", out result);
                return result;
            }
        }

        public System.String DeviceName
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceName", out result);
                return result;
            }
        }

        public System.Boolean? DeviceWakeUpEnable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DeviceWakeUpEnable", out result);
                return result;
            }
        }

        public System.String DriverDate
        {
            get
            {
                System.String result;
                this.GetProperty("DriverDate", out result);
                return result;
            }
        }

        public System.UInt64? DriverDateData
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DriverDateData", out result);
                return result;
            }
        }

        public System.String DriverDescription
        {
            get
            {
                System.String result;
                this.GetProperty("DriverDescription", out result);
                return result;
            }
        }

        public System.Byte? DriverMajorNdisVersion
        {
            get
            {
                System.Byte? result;
                this.GetProperty("DriverMajorNdisVersion", out result);
                return result;
            }
        }

        public System.Byte? DriverMinorNdisVersion
        {
            get
            {
                System.Byte? result;
                this.GetProperty("DriverMinorNdisVersion", out result);
                return result;
            }
        }

        public System.String DriverName
        {
            get
            {
                System.String result;
                this.GetProperty("DriverName", out result);
                return result;
            }
        }

        public System.String DriverProvider
        {
            get
            {
                System.String result;
                this.GetProperty("DriverProvider", out result);
                return result;
            }
        }

        public System.String DriverVersionString
        {
            get
            {
                System.String result;
                this.GetProperty("DriverVersionString", out result);
                return result;
            }
        }

        public System.Boolean? EndPointInterface
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EndPointInterface", out result);
                return result;
            }
        }

        public System.Boolean? HardwareInterface
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HardwareInterface", out result);
                return result;
            }
        }

        public System.Boolean? Hidden
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Hidden", out result);
                return result;
            }
        }

        public System.UInt32[] HigherLayerInterfaceIndices
        {
            get
            {
                System.UInt32[] result;
                this.GetProperty("HigherLayerInterfaceIndices", out result);
                return result;
            }
        }

        public System.Boolean? IMFilter
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IMFilter", out result);
                return result;
            }
        }

        public System.UInt32? InterfaceAdminStatus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterfaceAdminStatus", out result);
                return result;
            }
        }

        public System.String InterfaceDescription
        {
            get
            {
                System.String result;
                this.GetProperty("InterfaceDescription", out result);
                return result;
            }
        }

        public System.String InterfaceGuid
        {
            get
            {
                System.String result;
                this.GetProperty("InterfaceGuid", out result);
                return result;
            }
        }

        public System.UInt32? InterfaceIndex
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterfaceIndex", out result);
                return result;
            }
        }

        public System.String InterfaceName
        {
            get
            {
                System.String result;
                this.GetProperty("InterfaceName", out result);
                return result;
            }
        }

        public System.UInt32? InterfaceOperationalStatus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterfaceOperationalStatus", out result);
                return result;
            }
        }

        public System.UInt32? InterfaceType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterfaceType", out result);
                return result;
            }
        }

        public System.Boolean? ISCSIInterface
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("iSCSIInterface", out result);
                return result;
            }
        }

        public System.UInt32[] LowerLayerInterfaceIndices
        {
            get
            {
                System.UInt32[] result;
                this.GetProperty("LowerLayerInterfaceIndices", out result);
                return result;
            }
        }

        public System.UInt16? MajorDriverVersion
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MajorDriverVersion", out result);
                return result;
            }
        }

        public System.UInt32? MediaConnectState
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MediaConnectState", out result);
                return result;
            }
        }

        public System.UInt32? MediaDuplexState
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MediaDuplexState", out result);
                return result;
            }
        }

        public System.UInt16? MinorDriverVersion
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MinorDriverVersion", out result);
                return result;
            }
        }

        public System.UInt32? MtuSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MtuSize", out result);
                return result;
            }
        }

        public System.UInt32? NdisMedium
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NdisMedium", out result);
                return result;
            }
        }

        public System.UInt32? NdisPhysicalMedium
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NdisPhysicalMedium", out result);
                return result;
            }
        }

        public System.UInt64? NetLuid
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NetLuid", out result);
                return result;
            }
        }

        public System.UInt32? NetLuidIndex
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NetLuidIndex", out result);
                return result;
            }
        }

        public System.Boolean? NotUserRemovable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NotUserRemovable", out result);
                return result;
            }
        }

        public System.Boolean? OperationalStatusDownDefaultPortNotAuthenticated
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("OperationalStatusDownDefaultPortNotAuthenticated", out result);
                return result;
            }
        }

        public System.Boolean? OperationalStatusDownInterfacePaused
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("OperationalStatusDownInterfacePaused", out result);
                return result;
            }
        }

        public System.Boolean? OperationalStatusDownLowPowerState
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("OperationalStatusDownLowPowerState", out result);
                return result;
            }
        }

        public System.Boolean? OperationalStatusDownMediaDisconnected
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("OperationalStatusDownMediaDisconnected", out result);
                return result;
            }
        }

        public System.String PnPDeviceID
        {
            get
            {
                System.String result;
                this.GetProperty("PnPDeviceID", out result);
                return result;
            }
        }

        public System.Boolean? PromiscuousMode
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PromiscuousMode", out result);
                return result;
            }
        }

        public System.UInt64? ReceiveLinkSpeed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceiveLinkSpeed", out result);
                return result;
            }
        }

        public System.UInt32? State
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("State", out result);
                return result;
            }
        }

        public System.UInt64? TransmitLinkSpeed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TransmitLinkSpeed", out result);
                return result;
            }
        }

        public System.Boolean? Virtual
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Virtual", out result);
                return result;
            }
        }

        public System.UInt16? VlanID
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("VlanID", out result);
                return result;
            }

            set
            {
                this.SetProperty("VlanID", value);
            }
        }

        public System.Boolean? WdmInterface
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("WdmInterface", out result);
                return result;
            }
        }

        public (System.UInt32 retval, MSFTNetAdapter outCmdletOutput) Enable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapter)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["CmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapter outCmdletOutput) Disable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapter)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["CmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapter outCmdletOutput) Restart()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Restart", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapter)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["CmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapter outCmdletOutput) Lock()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Lock", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapter)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["CmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapter outCmdletOutput) Unlock()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Unlock", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapter)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["CmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapter outCmdletOutput) Rename(System.String inNewName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inNewName != null)
                parameters.Add(CimMethodParameter.Create("NewName", inNewName, CimType.String, inNewName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Rename", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapter)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["CmdletOutput"].Value));
        }
    }
}