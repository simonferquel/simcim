using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPEntity : CIMLogicalDevice
    {
        public Win32PnPEntity()
        {
        }

        public Win32PnPEntity(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ClassGuid
        {
            get
            {
                System.String result;
                this.GetProperty("ClassGuid", out result);
                return result;
            }
        }

        public System.String[] CompatibleID
        {
            get
            {
                System.String[] result;
                this.GetProperty("CompatibleID", out result);
                return result;
            }
        }

        public System.String[] HardwareID
        {
            get
            {
                System.String[] result;
                this.GetProperty("HardwareID", out result);
                return result;
            }
        }

        public System.String Manufacturer
        {
            get
            {
                System.String result;
                this.GetProperty("Manufacturer", out result);
                return result;
            }
        }

        public System.String PNPClass
        {
            get
            {
                System.String result;
                this.GetProperty("PNPClass", out result);
                return result;
            }
        }

        public System.Boolean? Present
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Present", out result);
                return result;
            }
        }

        public System.String Service
        {
            get
            {
                System.String result;
                this.GetProperty("Service", out result);
                return result;
            }
        }

        public (System.UInt32 retval, System.Boolean? outrebootNeeded) Enable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Boolean? )result.OutParameters["rebootNeeded"].Value);
        }

        public (System.UInt32 retval, System.Boolean? outrebootNeeded) Disable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Boolean? )result.OutParameters["rebootNeeded"].Value);
        }

        public (System.UInt32 retval, IEnumerable<Win32PnPDeviceProperty> outdeviceProperties) GetDeviceProperties(System.String[] indevicePropertyKeys)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("devicePropertyKeys", indevicePropertyKeys, indevicePropertyKeys == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetDeviceProperties", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<Win32PnPDeviceProperty>)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["deviceProperties"].Value));
        }

        public CIMLogicalDevice ResolveWin32PnPDeviceSameElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_PnPDevice", "CIM_LogicalDevice", "SystemElement", "SameElement");
            return instances.Select(i => (CIMLogicalDevice)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}