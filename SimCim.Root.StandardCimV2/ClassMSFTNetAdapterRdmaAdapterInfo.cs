using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterRdmaAdapterInfo : GenericInfrastructureObject
    {
        public MSFTNetAdapterRdmaAdapterInfo()
        {
        }

        public MSFTNetAdapterRdmaAdapterInfo(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? DeviceId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DeviceId", out result);
                return result;
            }
        }

        public System.UInt32? FRMRPageCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FRMRPageCount", out result);
                return result;
            }
        }

        public System.Boolean? InOrderDMA
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("InOrderDMA", out result);
                return result;
            }
        }

        public System.UInt32? LargeRequestThreshold
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LargeRequestThreshold", out result);
                return result;
            }
        }

        public System.UInt16? MajorVersionNumber
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MajorVersionNumber", out result);
                return result;
            }
        }

        public System.UInt32? MaxCalleeData
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxCalleeData", out result);
                return result;
            }
        }

        public System.UInt32? MaxCallerData
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxCallerData", out result);
                return result;
            }
        }

        public System.UInt32? MaxCompletionQueueDepth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxCompletionQueueDepth", out result);
                return result;
            }
        }

        public System.UInt32? MaxInboundReadLimit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxInboundReadLimit", out result);
                return result;
            }
        }

        public System.UInt32? MaxInitiatorQueueDepth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxInitiatorQueueDepth", out result);
                return result;
            }
        }

        public System.UInt32? MaxInitiatorRequestSge
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxInitiatorRequestSge", out result);
                return result;
            }
        }

        public System.UInt32? MaxInlineDataSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxInlineDataSize", out result);
                return result;
            }
        }

        public System.UInt32? MaxOutboundReadLimit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxOutboundReadLimit", out result);
                return result;
            }
        }

        public System.UInt32? MaxReadRequestSge
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxReadRequestSge", out result);
                return result;
            }
        }

        public System.UInt32? MaxReceiveQueueDepth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxReceiveQueueDepth", out result);
                return result;
            }
        }

        public System.UInt32? MaxReceiveRequestSge
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxReceiveRequestSge", out result);
                return result;
            }
        }

        public System.UInt64? MaxRegistrationSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxRegistrationSize", out result);
                return result;
            }
        }

        public System.UInt32? MaxSharedReceiveQueueDepth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxSharedReceiveQueueDepth", out result);
                return result;
            }
        }

        public System.UInt32? MaxTransferLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxTransferLength", out result);
                return result;
            }
        }

        public System.UInt64? MaxWindowSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxWindowSize", out result);
                return result;
            }
        }

        public System.UInt16? MinorVersionNumber
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MinorVersionNumber", out result);
                return result;
            }
        }

        public System.Boolean? RdmaReadSinkFlagNotRequired
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RdmaReadSinkFlagNotRequired", out result);
                return result;
            }
        }

        public System.UInt32? RdmaTechnology
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RdmaTechnology", out result);
                return result;
            }
        }

        public System.Boolean? SupportsCompletionQueueInterruptModeration
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsCompletionQueueInterruptModeration", out result);
                return result;
            }
        }

        public System.Boolean? SupportsCompletionQueueResize
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsCompletionQueueResize", out result);
                return result;
            }
        }

        public System.Boolean? SupportsLoopbackConnections
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsLoopbackConnections", out result);
                return result;
            }
        }

        public System.Boolean? SupportsMultiEngine
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsMultiEngine", out result);
                return result;
            }
        }

        public System.UInt32? VendorId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VendorId", out result);
                return result;
            }
        }
    }
}