using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmPciExpressSettingData : CIMResourceAllocationSettingData
    {
        public MsvmPciExpressSettingData()
        {
        }

        public MsvmPciExpressSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] VirtualFunctions
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("VirtualFunctions", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualFunctions", value);
            }
        }

        public System.String[] VirtualSystemIdentifiers
        {
            get
            {
                System.String[] result;
                this.GetProperty("VirtualSystemIdentifiers", out result);
                return result;
            }
        }
    }
}