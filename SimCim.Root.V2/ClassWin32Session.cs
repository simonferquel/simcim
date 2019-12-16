using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32Session : CIMLogicalElement
    {
        protected Win32Session()
        {
        }

        protected Win32Session(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.DateTime? StartTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("StartTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("StartTime", value);
            }
        }
    }
}