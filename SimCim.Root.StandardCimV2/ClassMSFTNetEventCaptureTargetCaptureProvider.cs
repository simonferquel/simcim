using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetEventCaptureTargetCaptureProvider : CIMComponent
    {
        public MSFTNetEventCaptureTargetCaptureProvider()
        {
        }

        public MSFTNetEventCaptureTargetCaptureProvider(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetEventPacketCaptureProvider GroupComponent
        {
            get
            {
                MSFTNetEventPacketCaptureProvider result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupComponent", value);
            }
        }

        public new MSFTNetEventPacketCaptureTarget PartComponent
        {
            get
            {
                MSFTNetEventPacketCaptureTarget result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("PartComponent", value);
            }
        }
    }
}