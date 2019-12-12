using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersAppVClientStreamedDataPercentage : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersAppVClientStreamedDataPercentage()
        {
        }

        public Win32PerfFormattedDataCountersAppVClientStreamedDataPercentage(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? PrimaryFeaturePercentStreamed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PrimaryFeaturePercentStreamed", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrimaryFeaturePercentStreamed", value);
            }
        }
    }
}