using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SystemDriverPNPEntity : CIMDependency
    {
        public Win32SystemDriverPNPEntity()
        {
        }

        public Win32SystemDriverPNPEntity(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CimInstance Antecedent
        {
            get
            {
                CimInstance result;
                this.GetProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32SystemDriver Dependent
        {
            get
            {
                Win32SystemDriver result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}