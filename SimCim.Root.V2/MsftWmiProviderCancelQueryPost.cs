using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MsftWmiProviderCancelQueryPost : MsftWmiProviderOperationEventPost
    {
        public MsftWmiProviderCancelQueryPost()
        {
        }

        public MsftWmiProviderCancelQueryPost(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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