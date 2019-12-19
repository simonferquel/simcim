﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterProcessorNumber : GenericInfrastructureObject
    {
        public MSFTNetAdapterProcessorNumber()
        {
        }

        public MSFTNetAdapterProcessorNumber(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? ProcessorGroup
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ProcessorGroup", out result);
                return result;
            }
        }

        public System.Byte? ProcessorNumber
        {
            get
            {
                System.Byte? result;
                this.GetProperty("ProcessorNumber", out result);
                return result;
            }
        }
    }
}