using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public abstract class Event : IndicationRelated
    {
        protected Event()
        {
        }

        protected Event(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte[] SECURITYDESCRIPTOR
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("SECURITY_DESCRIPTOR", out result);
                return result;
            }

            set
            {
                this.SetProperty("SECURITY_DESCRIPTOR", value);
            }
        }

        public System.UInt64? TIMECREATED
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TIME_CREATED", out result);
                return result;
            }

            set
            {
                this.SetProperty("TIME_CREATED", value);
            }
        }
    }
}