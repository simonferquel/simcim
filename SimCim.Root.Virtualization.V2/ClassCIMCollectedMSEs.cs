﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMCollectedMSEs : CIMMemberOfCollection
    {
        protected CIMCollectedMSEs()
        {
        }

        protected CIMCollectedMSEs(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMCollectionOfMSEs Collection
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

        public new CIMManagedSystemElement Member
        {
            get
            {
                CIMManagedSystemElement result;
                this.GetInfrastructureObjectProperty("Member", out result);
                return result;
            }

            set
            {
                this.SetProperty("Member", value);
            }
        }
    }
}