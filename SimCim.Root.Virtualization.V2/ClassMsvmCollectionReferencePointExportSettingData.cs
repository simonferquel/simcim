using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmCollectionReferencePointExportSettingData : CIMSettingData
    {
        public MsvmCollectionReferencePointExportSettingData()
        {
        }

        public MsvmCollectionReferencePointExportSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String BaseReferencePointCollection
        {
            get
            {
                System.String result;
                this.GetProperty("BaseReferencePointCollection", out result);
                return result;
            }

            set
            {
                this.SetProperty("BaseReferencePointCollection", value);
            }
        }

        public System.String[] VirtualMachinesToDisksToExport
        {
            get
            {
                System.String[] result;
                this.GetProperty("VirtualMachinesToDisksToExport", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualMachinesToDisksToExport", value);
            }
        }
    }
}