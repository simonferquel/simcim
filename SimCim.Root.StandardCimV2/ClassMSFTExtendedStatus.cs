using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTExtendedStatus : MSFTWmiError
    {
        public MSFTExtendedStatus()
        {
        }

        public MSFTExtendedStatus(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CimInstance OriginalError
        {
            get
            {
                CimInstance result;
                this.GetProperty("original_error", out result);
                return result;
            }

            set
            {
                this.SetProperty("original_error", value);
            }
        }
    }
}