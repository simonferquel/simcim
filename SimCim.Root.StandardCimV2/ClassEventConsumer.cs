using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public abstract class EventConsumer : IndicationRelated
    {
        protected EventConsumer()
        {
        }

        protected EventConsumer(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte[] CreatorSID
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("CreatorSID", out result);
                return result;
            }
        }

        public System.String MachineName
        {
            get
            {
                System.String result;
                this.GetProperty("MachineName", out result);
                return result;
            }

            set
            {
                this.SetProperty("MachineName", value);
            }
        }

        public System.UInt32? MaximumQueueSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumQueueSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaximumQueueSize", value);
            }
        }
    }
}