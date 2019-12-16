using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMStatistics : GenericInfrastructureObject
    {
        protected CIMStatistics()
        {
        }

        protected CIMStatistics(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMManagedSystemElement Element
        {
            get
            {
                CIMManagedSystemElement result;
                this.GetInfrastructureObjectProperty("Element", out result);
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