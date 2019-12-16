using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmAffectedStorageJobElement : CIMAffectedJobElement
    {
        public MsvmAffectedStorageJobElement()
        {
        }

        public MsvmAffectedStorageJobElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmStorageJob AffectingElement
        {
            get
            {
                MsvmStorageJob result;
                this.GetInfrastructureObjectProperty("AffectingElement", out result);
                return result;
            }
        }
    }
}