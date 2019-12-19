using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetTCPSetting : CIMPolicyAction
    {
        public MSFTNetTCPSetting()
        {
        }

        public MSFTNetTCPSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? AutomaticUseCustom
        {
            get
            {
                System.Byte? result;
                this.GetProperty("AutomaticUseCustom", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutomaticUseCustom", value);
            }
        }

        public System.UInt16? AutoReusePortRangeNumberOfPorts
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AutoReusePortRangeNumberOfPorts", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutoReusePortRangeNumberOfPorts", value);
            }
        }

        public System.UInt16? AutoReusePortRangeStartPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AutoReusePortRangeStartPort", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutoReusePortRangeStartPort", value);
            }
        }

        public System.Byte? AutoTuningLevelEffective
        {
            get
            {
                System.Byte? result;
                this.GetProperty("AutoTuningLevelEffective", out result);
                return result;
            }
        }

        public System.Byte? AutoTuningLevelGroupPolicy
        {
            get
            {
                System.Byte? result;
                this.GetProperty("AutoTuningLevelGroupPolicy", out result);
                return result;
            }
        }

        public System.Byte? AutoTuningLevelLocal
        {
            get
            {
                System.Byte? result;
                this.GetProperty("AutoTuningLevelLocal", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutoTuningLevelLocal", value);
            }
        }

        public System.Byte? CongestionProvider
        {
            get
            {
                System.Byte? result;
                this.GetProperty("CongestionProvider", out result);
                return result;
            }

            set
            {
                this.SetProperty("CongestionProvider", value);
            }
        }

        public System.Byte? CwndRestart
        {
            get
            {
                System.Byte? result;
                this.GetProperty("CwndRestart", out result);
                return result;
            }

            set
            {
                this.SetProperty("CwndRestart", value);
            }
        }

        public System.Byte? DelayedAckFrequency
        {
            get
            {
                System.Byte? result;
                this.GetProperty("DelayedAckFrequency", out result);
                return result;
            }

            set
            {
                this.SetProperty("DelayedAckFrequency", value);
            }
        }

        public System.UInt32? DelayedAckTimeout
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DelayedAckTimeout", out result);
                return result;
            }

            set
            {
                this.SetProperty("DelayedAckTimeout", value);
            }
        }

        public System.UInt16? DynamicPortRangeNumberOfPorts
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DynamicPortRangeNumberOfPorts", out result);
                return result;
            }

            set
            {
                this.SetProperty("DynamicPortRangeNumberOfPorts", value);
            }
        }

        public System.UInt16? DynamicPortRangeStartPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DynamicPortRangeStartPort", out result);
                return result;
            }

            set
            {
                this.SetProperty("DynamicPortRangeStartPort", value);
            }
        }

        public System.Byte? EcnCapability
        {
            get
            {
                System.Byte? result;
                this.GetProperty("EcnCapability", out result);
                return result;
            }

            set
            {
                this.SetProperty("EcnCapability", value);
            }
        }

        public System.Byte? ForceWS
        {
            get
            {
                System.Byte? result;
                this.GetProperty("ForceWS", out result);
                return result;
            }

            set
            {
                this.SetProperty("ForceWS", value);
            }
        }

        public System.UInt32? InitialCongestionWindow
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InitialCongestionWindow", out result);
                return result;
            }

            set
            {
                this.SetProperty("InitialCongestionWindow", value);
            }
        }

        public System.UInt32? InitialRto
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InitialRto", out result);
                return result;
            }

            set
            {
                this.SetProperty("InitialRto", value);
            }
        }

        public System.Byte? MaxSynRetransmissions
        {
            get
            {
                System.Byte? result;
                this.GetProperty("MaxSynRetransmissions", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxSynRetransmissions", value);
            }
        }

        public System.Byte? MemoryPressureProtection
        {
            get
            {
                System.Byte? result;
                this.GetProperty("MemoryPressureProtection", out result);
                return result;
            }

            set
            {
                this.SetProperty("MemoryPressureProtection", value);
            }
        }

        public System.UInt32? MinRto
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MinRto", out result);
                return result;
            }

            set
            {
                this.SetProperty("MinRto", value);
            }
        }

        public System.Byte? NonSackRttResiliency
        {
            get
            {
                System.Byte? result;
                this.GetProperty("NonSackRttResiliency", out result);
                return result;
            }

            set
            {
                this.SetProperty("NonSackRttResiliency", value);
            }
        }

        public System.Byte? ScalingHeuristics
        {
            get
            {
                System.Byte? result;
                this.GetProperty("ScalingHeuristics", out result);
                return result;
            }

            set
            {
                this.SetProperty("ScalingHeuristics", value);
            }
        }

        public System.String SettingName
        {
            get
            {
                System.String result;
                this.GetProperty("SettingName", out result);
                return result;
            }
        }

        public System.Byte? Timestamps
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Timestamps", out result);
                return result;
            }

            set
            {
                this.SetProperty("Timestamps", value);
            }
        }
    }
}