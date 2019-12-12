using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTWMIGenericNonCOMEvent : ExtrinsicEvent
    {
        public MSFTWMIGenericNonCOMEvent()
        {
        }

        public MSFTWMIGenericNonCOMEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ProcessId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessId", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProcessId", value);
            }
        }

        public System.String[] PropertyNames
        {
            get
            {
                System.String[] result;
                this.GetProperty("PropertyNames", out result);
                return result;
            }

            set
            {
                this.SetProperty("PropertyNames", value);
            }
        }

        public System.String[] PropertyValues
        {
            get
            {
                System.String[] result;
                this.GetProperty("PropertyValues", out result);
                return result;
            }

            set
            {
                this.SetProperty("PropertyValues", value);
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
    }
}