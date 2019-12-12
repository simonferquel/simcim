using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTWmiCancelNotificationSink : MSFTWmiEssEvent
    {
        public MSFTWmiCancelNotificationSink()
        {
        }

        public MSFTWmiCancelNotificationSink(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Namespace
        {
            get
            {
                System.String result;
                this.GetProperty("Namespace", out result);
                return result;
            }

            set
            {
                this.SetProperty("Namespace", value);
            }
        }

        public System.String Query
        {
            get
            {
                System.String result;
                this.GetProperty("Query", out result);
                return result;
            }

            set
            {
                this.SetProperty("Query", value);
            }
        }

        public System.String QueryLanguage
        {
            get
            {
                System.String result;
                this.GetProperty("QueryLanguage", out result);
                return result;
            }

            set
            {
                this.SetProperty("QueryLanguage", value);
            }
        }

        public System.UInt64? Sink
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Sink", out result);
                return result;
            }

            set
            {
                this.SetProperty("Sink", value);
            }
        }
    }
}