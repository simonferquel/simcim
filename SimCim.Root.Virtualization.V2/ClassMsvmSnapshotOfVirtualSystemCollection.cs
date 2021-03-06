﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSnapshotOfVirtualSystemCollection : CIMDependency
    {
        public MsvmSnapshotOfVirtualSystemCollection()
        {
        }

        public MsvmSnapshotOfVirtualSystemCollection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMCollectionOfMSEs Antecedent
        {
            get
            {
                CIMCollectionOfMSEs result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new CIMCollection Dependent
        {
            get
            {
                CIMCollection result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Dependent", value);
            }
        }
    }
}