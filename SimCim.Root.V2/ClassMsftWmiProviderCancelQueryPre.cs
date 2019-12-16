using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MsftWmiProviderCancelQueryPre : MsftWmiProviderOperationEventPre
    {
        public MsftWmiProviderCancelQueryPre()
        {
        }

        public MsftWmiProviderCancelQueryPre(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? QueryId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QueryId", out result);
                return result;
            }

            set
            {
                this.SetProperty("QueryId", value);
            }
        }
    }
}