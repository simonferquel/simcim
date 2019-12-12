using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MsftWmiProviderPutInstanceAsyncEventPre : MsftWmiProviderOperationEventPre
    {
        public MsftWmiProviderPutInstanceAsyncEventPre()
        {
        }

        public MsftWmiProviderPutInstanceAsyncEventPre(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Flags
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Flags", out result);
                return result;
            }

            set
            {
                this.SetProperty("Flags", value);
            }
        }

        public CimInstance InstanceObject
        {
            get
            {
                CimInstance result;
                this.GetProperty("InstanceObject", out result);
                return result;
            }

            set
            {
                this.SetProperty("InstanceObject", value);
            }
        }
    }
}