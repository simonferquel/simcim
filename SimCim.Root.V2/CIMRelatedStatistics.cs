using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMRelatedStatistics : GenericInfrastructureObject
    {
        protected CIMRelatedStatistics()
        {
        }

        protected CIMRelatedStatistics(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMStatisticalInformation RelatedStats
        {
            get
            {
                CIMStatisticalInformation result;
                this.GetInfrastructureObjectProperty("RelatedStats", out result);
                return result;
            }
        }

        public CIMStatisticalInformation Stats
        {
            get
            {
                CIMStatisticalInformation result;
                this.GetInfrastructureObjectProperty("Stats", out result);
                return result;
            }
        }
    }
}