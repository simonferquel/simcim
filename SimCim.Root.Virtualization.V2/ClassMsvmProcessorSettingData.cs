using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmProcessorSettingData : CIMResourceAllocationSettingData
    {
        public MsvmProcessorSettingData()
        {
        }

        public MsvmProcessorSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AllowACountMCount
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AllowACountMCount", out result);
                return result;
            }
        }

        public System.String CpuGroupId
        {
            get
            {
                System.String result;
                this.GetProperty("CpuGroupId", out result);
                return result;
            }
        }

        public System.Boolean? DisableSpeculationControls
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DisableSpeculationControls", out result);
                return result;
            }

            set
            {
                this.SetProperty("DisableSpeculationControls", value);
            }
        }

        public System.Boolean? EnableHostResourceProtection
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableHostResourceProtection", out result);
                return result;
            }
        }

        public System.Boolean? EnableLegacyApicMode
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableLegacyApicMode", out result);
                return result;
            }
        }

        public System.Byte? EnablePageShattering
        {
            get
            {
                System.Byte? result;
                this.GetProperty("EnablePageShattering", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnablePageShattering", value);
            }
        }

        public System.Boolean? EnablePerfmonIpt
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnablePerfmonIpt", out result);
                return result;
            }
        }

        public System.Boolean? EnablePerfmonLbr
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnablePerfmonLbr", out result);
                return result;
            }
        }

        public System.Boolean? EnablePerfmonPebs
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnablePerfmonPebs", out result);
                return result;
            }
        }

        public System.Boolean? EnablePerfmonPmu
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnablePerfmonPmu", out result);
                return result;
            }
        }

        public System.Boolean? ExposeVirtualizationExtensions
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ExposeVirtualizationExtensions", out result);
                return result;
            }
        }

        public System.Boolean? HideHypervisorPresent
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HideHypervisorPresent", out result);
                return result;
            }
        }

        public System.UInt64? HwThreadsPerCore
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HwThreadsPerCore", out result);
                return result;
            }
        }

        public System.Boolean? LimitCPUID
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("LimitCPUID", out result);
                return result;
            }
        }

        public System.Boolean? LimitProcessorFeatures
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("LimitProcessorFeatures", out result);
                return result;
            }
        }

        public System.UInt64? MaxNumaNodesPerSocket
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxNumaNodesPerSocket", out result);
                return result;
            }
        }

        public System.UInt64? MaxProcessorsPerNumaNode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxProcessorsPerNumaNode", out result);
                return result;
            }
        }
    }
}