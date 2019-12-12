using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNCProvEvent : ExtrinsicEvent
    {
        public MSFTNCProvEvent()
        {
        }

        public MSFTNCProvEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.String ProviderName
        {
            get
            {
                System.String result;
                this.GetProperty("ProviderName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderName", value);
            }
        }

        public System.UInt32? Result
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Result", out result);
                return result;
            }

            set
            {
                this.SetProperty("Result", value);
            }
        }
    }
}