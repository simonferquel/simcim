using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualSystemReferencePointExportSettingData : CIMSettingData
    {
        public MsvmVirtualSystemReferencePointExportSettingData()
        {
        }

        public MsvmVirtualSystemReferencePointExportSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String BaseReferencePoint
        {
            get
            {
                System.String result;
                this.GetProperty("BaseReferencePoint", out result);
                return result;
            }
        }

        public System.String[] DisksToExport
        {
            get
            {
                System.String[] result;
                this.GetProperty("DisksToExport", out result);
                return result;
            }
        }
    }
}