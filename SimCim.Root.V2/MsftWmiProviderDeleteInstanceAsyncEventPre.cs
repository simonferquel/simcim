﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MsftWmiProviderDeleteInstanceAsyncEventPre : MsftWmiProviderOperationEventPre
    {
        public MsftWmiProviderDeleteInstanceAsyncEventPre()
        {
        }

        public MsftWmiProviderDeleteInstanceAsyncEventPre(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.String ObjectPath
        {
            get
            {
                System.String result;
                this.GetProperty("ObjectPath", out result);
                return result;
            }

            set
            {
                this.SetProperty("ObjectPath", value);
            }
        }
    }
}