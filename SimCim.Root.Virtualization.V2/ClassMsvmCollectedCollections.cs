﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmCollectedCollections : CIMCollectedMSEs
    {
        public MsvmCollectedCollections()
        {
        }

        public MsvmCollectedCollections(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmManagementCollection Collection
        {
            get
            {
                MsvmManagementCollection result;
                this.GetInfrastructureObjectProperty("Collection", out result);
                return result;
            }

            set
            {
                this.SetProperty("Collection", value);
            }
        }

        public new CIMCollectionOfMSEs Member
        {
            get
            {
                CIMCollectionOfMSEs result;
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