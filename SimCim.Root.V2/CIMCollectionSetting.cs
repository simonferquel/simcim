using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMCollectionSetting : GenericInfrastructureObject
    {
        protected CIMCollectionSetting()
        {
        }

        protected CIMCollectionSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public CIMSetting Setting
        {
            get
            {
                CIMSetting result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }

            set
            {
                this.SetProperty("Setting", value);
            }
        }
    }
}