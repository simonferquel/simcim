using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMStorageRedundancyGroup : CIMRedundancyGroup
    {
        protected CIMStorageRedundancyGroup()
        {
        }

        protected CIMStorageRedundancyGroup(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? TypeOfAlgorithm
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TypeOfAlgorithm", out result);
                return result;
            }
        }
    }
}