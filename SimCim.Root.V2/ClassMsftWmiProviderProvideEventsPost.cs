﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MsftWmiProviderProvideEventsPost : MsftWmiProviderOperationEventPost
    {
        public MsftWmiProviderProvideEventsPost()
        {
        }

        public MsftWmiProviderProvideEventsPost(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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