﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMHostedAccessPoint : CIMHostedDependency
    {
        protected CIMHostedAccessPoint()
        {
        }

        protected CIMHostedAccessPoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMSystem Antecedent
        {
            get
            {
                CIMSystem result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new CIMServiceAccessPoint Dependent
        {
            get
            {
                CIMServiceAccessPoint result;
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