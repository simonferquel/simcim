using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class FilterToConsumerBinding : IndicationRelated
    {
        public FilterToConsumerBinding()
        {
        }

        public FilterToConsumerBinding(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public EventConsumer Consumer
        {
            get
            {
                EventConsumer result;
                this.GetInfrastructureObjectProperty("Consumer", out result);
                return result;
            }

            set
            {
                this.SetProperty("Consumer", value);
            }
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

        public System.Boolean DeliverSynchronously
        {
            get
            {
                System.Boolean result;
                this.GetProperty("DeliverSynchronously", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeliverSynchronously", value);
            }
        }

        public System.UInt32? DeliveryQoS
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DeliveryQoS", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeliveryQoS", value);
            }
        }

        public EventFilter Filter
        {
            get
            {
                EventFilter result;
                this.GetInfrastructureObjectProperty("Filter", out result);
                return result;
            }

            set
            {
                this.SetProperty("Filter", value);
            }
        }

        public System.Boolean? MaintainSecurityContext
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MaintainSecurityContext", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaintainSecurityContext", value);
            }
        }

        public System.Boolean? SlowDownProviders
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SlowDownProviders", out result);
                return result;
            }

            set
            {
                this.SetProperty("SlowDownProviders", value);
            }
        }
    }
}