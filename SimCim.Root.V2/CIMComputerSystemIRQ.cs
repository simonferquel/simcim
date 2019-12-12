﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMComputerSystemIRQ : CIMComputerSystemResource
    {
        protected CIMComputerSystemIRQ()
        {
        }

        protected CIMComputerSystemIRQ(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMIRQ PartComponent
        {
            get
            {
                CIMIRQ result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}