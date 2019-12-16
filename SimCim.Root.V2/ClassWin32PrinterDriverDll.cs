using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PrinterDriverDll : CIMDependency
    {
        public Win32PrinterDriverDll()
        {
        }

        public Win32PrinterDriverDll(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMDataFile Antecedent
        {
            get
            {
                CIMDataFile result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32Printer Dependent
        {
            get
            {
                Win32Printer result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}