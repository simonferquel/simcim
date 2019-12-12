using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersAppVClientStreamedDataPercentage : Win32PerfRawData
    {
        public Win32PerfRawDataCountersAppVClientStreamedDataPercentage()
        {
        }

        public Win32PerfRawDataCountersAppVClientStreamedDataPercentage(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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