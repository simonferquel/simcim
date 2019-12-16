using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class QOSFailureEvent : EventDroppedEvent
    {
        public QOSFailureEvent()
        {
        }

        public QOSFailureEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ErrorCode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorCode", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorCode", value);
            }
        }

        public System.String ErrorDescription
        {
            get
            {
                System.String result;
                this.GetProperty("ErrorDescription", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorDescription", value);
            }
        }
    }
}