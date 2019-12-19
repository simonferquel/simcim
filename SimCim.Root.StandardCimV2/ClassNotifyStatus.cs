using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public abstract class NotifyStatus : GenericInfrastructureObject
    {
        protected NotifyStatus()
        {
        }

        protected NotifyStatus(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? StatusCode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StatusCode", out result);
                return result;
            }

            set
            {
                this.SetProperty("StatusCode", value);
            }
        }
    }
}