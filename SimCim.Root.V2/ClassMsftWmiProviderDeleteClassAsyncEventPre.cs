using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MsftWmiProviderDeleteClassAsyncEventPre : MsftWmiProviderOperationEventPre
    {
        public MsftWmiProviderDeleteClassAsyncEventPre()
        {
        }

        public MsftWmiProviderDeleteClassAsyncEventPre(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ClassName
        {
            get
            {
                System.String result;
                this.GetProperty("ClassName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ClassName", value);
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