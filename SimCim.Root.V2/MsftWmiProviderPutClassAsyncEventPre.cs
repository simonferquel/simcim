using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MsftWmiProviderPutClassAsyncEventPre : MsftWmiProviderOperationEventPre
    {
        public MsftWmiProviderPutClassAsyncEventPre()
        {
        }

        public MsftWmiProviderPutClassAsyncEventPre(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CimInstance ClassObject
        {
            get
            {
                CimInstance result;
                this.GetProperty("ClassObject", out result);
                return result;
            }

            set
            {
                this.SetProperty("ClassObject", value);
            }
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
    }
}