using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public abstract class MSFTNetImPlatAdapter : CIMEnabledLogicalElement
    {
        protected MSFTNetImPlatAdapter()
        {
        }

        protected MSFTNetImPlatAdapter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? FailureReason
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FailureReason", out result);
                return result;
            }

            set
            {
                this.SetProperty("FailureReason", value);
            }
        }

        public System.String InterfaceDescription
        {
            get
            {
                System.String result;
                this.GetProperty("InterfaceDescription", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterfaceDescription", value);
            }
        }

        public System.UInt32? NumberOfFailures
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfFailures", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfFailures", value);
            }
        }

        public System.UInt64? ReceiveLinkSpeed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceiveLinkSpeed", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiveLinkSpeed", value);
            }
        }

        public System.String Team
        {
            get
            {
                System.String result;
                this.GetProperty("Team", out result);
                return result;
            }

            set
            {
                this.SetProperty("Team", value);
            }
        }

        public System.UInt64? TransmitLinkSpeed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TransmitLinkSpeed", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransmitLinkSpeed", value);
            }
        }
    }
}