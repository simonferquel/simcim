using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmProcessor : CIMProcessor
    {
        public MsvmProcessor()
        {
        }

        public MsvmProcessor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] LoadPercentageHistory
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("LoadPercentageHistory", out result);
                return result;
            }
        }
    }
}