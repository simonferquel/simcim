using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSystemExportSettingData : CIMElementSettingData
    {
        public MsvmSystemExportSettingData()
        {
        }

        public MsvmSystemExportSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMComputerSystem ManagedElement
        {
            get
            {
                CIMComputerSystem result;
                this.GetInfrastructureObjectProperty("ManagedElement", out result);
                return result;
            }
        }

        public new MsvmVirtualSystemExportSettingData SettingData
        {
            get
            {
                MsvmVirtualSystemExportSettingData result;
                this.GetInfrastructureObjectProperty("SettingData", out result);
                return result;
            }
        }
    }
}