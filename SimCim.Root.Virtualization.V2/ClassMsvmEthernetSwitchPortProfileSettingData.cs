using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchPortProfileSettingData : MsvmEthernetSwitchPortFeatureSettingData
    {
        public MsvmEthernetSwitchPortProfileSettingData()
        {
        }

        public MsvmEthernetSwitchPortProfileSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CdnLabelId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CdnLabelId", out result);
                return result;
            }

            set
            {
                this.SetProperty("CdnLabelId", value);
            }
        }

        public System.String CdnLabelString
        {
            get
            {
                System.String result;
                this.GetProperty("CdnLabelString", out result);
                return result;
            }

            set
            {
                this.SetProperty("CdnLabelString", value);
            }
        }

        public System.String NetCfgInstanceId
        {
            get
            {
                System.String result;
                this.GetProperty("NetCfgInstanceId", out result);
                return result;
            }

            set
            {
                this.SetProperty("NetCfgInstanceId", value);
            }
        }

        public System.UInt32? PciBusNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PciBusNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("PciBusNumber", value);
            }
        }

        public System.UInt32? PciDeviceNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PciDeviceNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("PciDeviceNumber", value);
            }
        }

        public System.UInt32? PciFunctionNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PciFunctionNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("PciFunctionNumber", value);
            }
        }

        public System.UInt32? PciSegmentNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PciSegmentNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("PciSegmentNumber", value);
            }
        }

        public System.UInt32? ProfileData
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProfileData", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProfileData", value);
            }
        }

        public System.String ProfileId
        {
            get
            {
                System.String result;
                this.GetProperty("ProfileId", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProfileId", value);
            }
        }

        public System.String ProfileName
        {
            get
            {
                System.String result;
                this.GetProperty("ProfileName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProfileName", value);
            }
        }

        public System.String VendorId
        {
            get
            {
                System.String result;
                this.GetProperty("VendorId", out result);
                return result;
            }

            set
            {
                this.SetProperty("VendorId", value);
            }
        }

        public System.String VendorName
        {
            get
            {
                System.String result;
                this.GetProperty("VendorName", out result);
                return result;
            }

            set
            {
                this.SetProperty("VendorName", value);
            }
        }
    }
}