using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMVideoHead : CIMLogicalDevice
    {
        protected CIMVideoHead()
        {
        }

        protected CIMVideoHead(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CurrentBitsPerPixel
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentBitsPerPixel", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentBitsPerPixel", value);
            }
        }

        public System.UInt32? CurrentHorizontalResolution
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentHorizontalResolution", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentHorizontalResolution", value);
            }
        }

        public System.UInt64? CurrentNumberOfColors
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CurrentNumberOfColors", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentNumberOfColors", value);
            }
        }

        public System.UInt32? CurrentNumberOfColumns
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentNumberOfColumns", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentNumberOfColumns", value);
            }
        }

        public System.UInt32? CurrentNumberOfRows
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentNumberOfRows", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentNumberOfRows", value);
            }
        }

        public System.UInt32? CurrentRefreshRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentRefreshRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentRefreshRate", value);
            }
        }

        public System.UInt16? CurrentScanMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CurrentScanMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentScanMode", value);
            }
        }

        public System.UInt32? CurrentVerticalResolution
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentVerticalResolution", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentVerticalResolution", value);
            }
        }

        public System.UInt32? MaxRefreshRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxRefreshRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxRefreshRate", value);
            }
        }

        public System.UInt32? MinRefreshRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MinRefreshRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("MinRefreshRate", value);
            }
        }

        public System.String OtherCurrentScanMode
        {
            get
            {
                System.String result;
                this.GetProperty("OtherCurrentScanMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherCurrentScanMode", value);
            }
        }

        public CIMDisplayController ResolveCIMVideoHeadOnControllerAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_VideoHeadOnController", "CIM_DisplayController", "Dependent", "Antecedent");
            return instances.Select(i => (CIMDisplayController)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}