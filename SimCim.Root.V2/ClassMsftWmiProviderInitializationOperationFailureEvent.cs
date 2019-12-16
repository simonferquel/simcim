using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MsftWmiProviderInitializationOperationFailureEvent : MsftWmiProviderOperationEvent
    {
        public MsftWmiProviderInitializationOperationFailureEvent()
        {
        }

        public MsftWmiProviderInitializationOperationFailureEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ResultCode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ResultCode", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResultCode", value);
            }
        }
    }
}