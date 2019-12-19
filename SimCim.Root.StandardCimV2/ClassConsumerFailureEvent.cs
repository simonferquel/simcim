using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class ConsumerFailureEvent : EventDroppedEvent
    {
        public ConsumerFailureEvent()
        {
        }

        public ConsumerFailureEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public ExtendedStatus ErrorObject
        {
            get
            {
                ExtendedStatus result;
                this.GetInfrastructureObjectProperty("ErrorObject", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorObject", value);
            }
        }
    }
}