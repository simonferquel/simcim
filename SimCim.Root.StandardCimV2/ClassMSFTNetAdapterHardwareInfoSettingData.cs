using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterHardwareInfoSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterHardwareInfoSettingData()
        {
        }

        public MSFTNetAdapterHardwareInfoSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BusNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BusNumber", out result);
                return result;
            }
        }

        public System.UInt32? DeviceNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DeviceNumber", out result);
                return result;
            }
        }

        public System.Boolean? Dma64BitSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Dma64BitSupported", out result);
                return result;
            }
        }

        public System.UInt32? FunctionNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FunctionNumber", out result);
                return result;
            }
        }

        public System.Boolean? LineBasedInterrupts
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("LineBasedInterrupts", out result);
                return result;
            }
        }

        public System.Boolean? LineBasedInterruptSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("LineBasedInterruptSupported", out result);
                return result;
            }
        }

        public System.String LocationInformationString
        {
            get
            {
                System.String result;
                this.GetProperty("LocationInformationString", out result);
                return result;
            }
        }

        public System.UInt32? MaxInterruptMessages
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxInterruptMessages", out result);
                return result;
            }
        }

        public System.Boolean? MsiEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MsiEnabled", out result);
                return result;
            }
        }

        public System.Boolean? MsiInterruptSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MsiInterruptSupported", out result);
                return result;
            }
        }

        public System.Boolean? MsiSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MsiSupported", out result);
                return result;
            }
        }

        public System.Boolean? MsiXEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MsiXEnabled", out result);
                return result;
            }
        }

        public System.Boolean? MsiXInterruptSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MsiXInterruptSupported", out result);
                return result;
            }
        }

        public IEnumerable<MSFTNetAdapterGroupAffinity> MsixMessageAffinityArray
        {
            get
            {
                IEnumerable<MSFTNetAdapterGroupAffinity> result;
                this.GetInfrastructureObjectProperty("MsixMessageAffinityArray", out result);
                return result;
            }
        }

        public System.Boolean? MsiXSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MsiXSupported", out result);
                return result;
            }
        }

        public System.Boolean? NoInterrupt
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NoInterrupt", out result);
                return result;
            }
        }

        public System.UInt16? NumaNode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NumaNode", out result);
                return result;
            }
        }

        public System.UInt32? NumMsiMessages
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumMsiMessages", out result);
                return result;
            }
        }

        public System.UInt32? NumMsixTableEntries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumMsixTableEntries", out result);
                return result;
            }
        }

        public System.UInt32? PciCurrentSpeedAndMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PciCurrentSpeedAndMode", out result);
                return result;
            }
        }

        public System.UInt32? PciDeviceLabelID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PciDeviceLabelID", out result);
                return result;
            }
        }

        public System.String PciDeviceLabelString
        {
            get
            {
                System.String result;
                this.GetProperty("PciDeviceLabelString", out result);
                return result;
            }
        }

        public System.UInt32? PciDeviceType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PciDeviceType", out result);
                return result;
            }
        }

        public System.UInt32? PciExpressCurrentLinkSpeedEncoded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PciExpressCurrentLinkSpeedEncoded", out result);
                return result;
            }
        }

        public System.UInt32? PciExpressCurrentLinkWidth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PciExpressCurrentLinkWidth", out result);
                return result;
            }
        }

        public System.UInt32? PciExpressCurrentPayloadSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PciExpressCurrentPayloadSize", out result);
                return result;
            }
        }

        public System.UInt32? PciExpressMaxLinkSpeedEncoded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PciExpressMaxLinkSpeedEncoded", out result);
                return result;
            }
        }

        public System.UInt32? PciExpressMaxLinkWidth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PciExpressMaxLinkWidth", out result);
                return result;
            }
        }

        public System.UInt32? PciExpressMaxPayloadSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PciExpressMaxPayloadSize", out result);
                return result;
            }
        }

        public System.UInt32? PciExpressMaxReadRequestSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PciExpressMaxReadRequestSize", out result);
                return result;
            }
        }

        public System.UInt32? PciExpressVersion
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PciExpressVersion", out result);
                return result;
            }
        }

        public System.UInt32? PciXCurrentSpeedAndMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PciXCurrentSpeedAndMode", out result);
                return result;
            }
        }

        public System.Boolean? S0WakeupSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("S0WakeupSupported", out result);
                return result;
            }
        }

        public System.UInt32? SegmentNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SegmentNumber", out result);
                return result;
            }
        }

        public System.UInt32? SlotNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SlotNumber", out result);
                return result;
            }
        }

        public System.UInt32? SriovSupport
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SriovSupport", out result);
                return result;
            }
        }
    }
}