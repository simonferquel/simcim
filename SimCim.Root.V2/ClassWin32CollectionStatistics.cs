using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32CollectionStatistics : GenericInfrastructureObject
    {
        protected Win32CollectionStatistics()
        {
        }

        protected Win32CollectionStatistics(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMCollectionOfMSEs Collection
        {
            get
            {
                CIMCollectionOfMSEs result;
                this.GetInfrastructureObjectProperty("Collection", out result);
                return result;
            }

            set
            {
                this.SetProperty("Collection", value);
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

            set
            {
                this.SetProperty("Stats", value);
            }
        }
    }
}