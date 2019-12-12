using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LoadOrderGroupServiceDependencies : CIMDependency
    {
        public Win32LoadOrderGroupServiceDependencies()
        {
        }

        public Win32LoadOrderGroupServiceDependencies(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32LoadOrderGroup Antecedent
        {
            get
            {
                Win32LoadOrderGroup result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32BaseService Dependent
        {
            get
            {
                Win32BaseService result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}