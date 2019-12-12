using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMBootOSFromFS : CIMDependency
    {
        protected CIMBootOSFromFS()
        {
        }

        protected CIMBootOSFromFS(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMFileSystem Antecedent
        {
            get
            {
                CIMFileSystem result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMOperatingSystem Dependent
        {
            get
            {
                CIMOperatingSystem result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}