using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ApplicationCommandLine : CIMServiceAccessBySAP
    {
        public Win32ApplicationCommandLine()
        {
        }

        public Win32ApplicationCommandLine(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32ApplicationService Antecedent
        {
            get
            {
                Win32ApplicationService result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32CommandLineAccess Dependent
        {
            get
            {
                Win32CommandLineAccess result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}