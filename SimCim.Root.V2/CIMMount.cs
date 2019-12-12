﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMMount : CIMDependency
    {
        protected CIMMount()
        {
        }

        protected CIMMount(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMDirectory Antecedent
        {
            get
            {
                CIMDirectory result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMNFS Dependent
        {
            get
            {
                CIMNFS result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}