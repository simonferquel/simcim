using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmAssignableDeviceService : CIMService
    {
        public MsvmAssignableDeviceService()
        {
        }

        public MsvmAssignableDeviceService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, System.String outDismountedDeviceInstancePath, CIMConcreteJob outJob) DismountAssignableDevice(System.String inDismountSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("DismountSettingData", inDismountSettingData, CimType.String, inDismountSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DismountAssignableDevice", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["DismountedDeviceInstancePath"].Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, System.String outMountedDeviceInstancePath) MountAssignableDevice(System.String inDeviceInstancePath, System.String inDeviceLocationPath)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("DeviceInstancePath", inDeviceInstancePath, CimType.String, inDeviceInstancePath == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("DeviceLocationPath", inDeviceLocationPath, CimType.String, inDeviceLocationPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "MountAssignableDevice", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value), (System.String)result.OutParameters["MountedDeviceInstancePath"].Value);
        }
    }
}