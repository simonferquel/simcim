using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetOffloadGlobalSetting : MSFTNetSettingData
    {
        public MSFTNetOffloadGlobalSetting()
        {
        }

        public MSFTNetOffloadGlobalSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? Chimney
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Chimney", out result);
                return result;
            }

            set
            {
                this.SetProperty("Chimney", value);
            }
        }

        public System.Byte? NetworkDirect
        {
            get
            {
                System.Byte? result;
                this.GetProperty("NetworkDirect", out result);
                return result;
            }

            set
            {
                this.SetProperty("NetworkDirect", value);
            }
        }

        public System.Byte? NetworkDirectAcrossIPSubnets
        {
            get
            {
                System.Byte? result;
                this.GetProperty("NetworkDirectAcrossIPSubnets", out result);
                return result;
            }

            set
            {
                this.SetProperty("NetworkDirectAcrossIPSubnets", value);
            }
        }

        public System.Byte? PacketCoalescingFilter
        {
            get
            {
                System.Byte? result;
                this.GetProperty("PacketCoalescingFilter", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketCoalescingFilter", value);
            }
        }

        public System.Byte? ReceiveSegmentCoalescing
        {
            get
            {
                System.Byte? result;
                this.GetProperty("ReceiveSegmentCoalescing", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiveSegmentCoalescing", value);
            }
        }

        public System.Byte? ReceiveSideScaling
        {
            get
            {
                System.Byte? result;
                this.GetProperty("ReceiveSideScaling", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiveSideScaling", value);
            }
        }

        public System.Byte? TaskOffload
        {
            get
            {
                System.Byte? result;
                this.GetProperty("TaskOffload", out result);
                return result;
            }

            set
            {
                this.SetProperty("TaskOffload", value);
            }
        }
    }
}