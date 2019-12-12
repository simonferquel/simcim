using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMResidesOnExtent : CIMDependency
    {
        protected CIMResidesOnExtent()
        {
        }

        protected CIMResidesOnExtent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMStorageExtent Antecedent
        {
            get
            {
                CIMStorageExtent result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMFileSystem Dependent
        {
            get
            {
                CIMFileSystem result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}