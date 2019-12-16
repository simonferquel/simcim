using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSyntheticFcPortSettingData : CIMResourceAllocationSettingData
    {
        public MsvmSyntheticFcPortSettingData()
        {
        }

        public MsvmSyntheticFcPortSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? ChapEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ChapEnabled", out result);
                return result;
            }
        }

        public System.String SecondaryWWNN
        {
            get
            {
                System.String result;
                this.GetProperty("SecondaryWWNN", out result);
                return result;
            }
        }

        public System.String SecondaryWWPN
        {
            get
            {
                System.String result;
                this.GetProperty("SecondaryWWPN", out result);
                return result;
            }
        }

        public System.String VirtualPortWWNN
        {
            get
            {
                System.String result;
                this.GetProperty("VirtualPortWWNN", out result);
                return result;
            }
        }

        public System.String VirtualPortWWPN
        {
            get
            {
                System.String result;
                this.GetProperty("VirtualPortWWPN", out result);
                return result;
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