using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMElementConformsToProfile : GenericInfrastructureObject
    {
        protected CIMElementConformsToProfile()
        {
        }

        protected CIMElementConformsToProfile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CimInstance ConformantStandard
        {
            get
            {
                CimInstance result;
                this.GetProperty("ConformantStandard", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConformantStandard", value);
            }
        }

        public CIMManagedElement ManagedElement
        {
            get
            {
                CIMManagedElement result;
                this.GetInfrastructureObjectProperty("ManagedElement", out result);
                return result;
            }

            set
            {
                this.SetProperty("ManagedElement", value);
            }
        }
    }
}